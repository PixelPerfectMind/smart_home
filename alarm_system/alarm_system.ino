#include <Arduino.h>
#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <ezButton.h>
 
// Config
#define STASSID "S23 Ultra von Jonas"
#define STAPSK "#*4ZgzSB"
#define MQTTIP "192.168.229.106"
#define SUBTOPIC "SmartHome/AlarmSystem"
#define PORT 1883
#define CLIENTNAME "ESP8266_ALARMSYSTEM"
 
// GPIO Pins
const int BUTTON_PIN = 5;     // D1 on ESP8266
const int LED_PIN = 2;        // D4 on ESP8266
const int SPEAKER = 13;       // D7 on ESP8266

ezButton button(BUTTON_PIN);  // ezButton on BUTTON_PIN;
 
WiFiClient espClient;
PubSubClient mqttClient(espClient);
 
String Message;
bool alarmIsActive = false;

void setup() {
  pinMode(LED_BUILTIN, OUTPUT);
  button.setDebounceTime(50); // Set button debounce time to 50 milliseconds
 
  Serial.begin(9600);
  delay(100);
  
  // Create WiFi conntection
  Serial.println("Connecting to WiFi...");
  WiFi.mode(WIFI_STA);
  WiFi.begin(STASSID, STAPSK);
  while (WiFi.status() != WL_CONNECTED) {
    digitalWrite(LED_BUILTIN, LOW);
    delay(500);
    digitalWrite(LED_BUILTIN, HIGH);
    Serial.print(".");
    delay(500);
  }
  Serial.println("");
  Serial.println("Connected to WiFi!");
  Serial.println("IP Address: ");
  Serial.println(WiFi.localIP());
  
  // Set up MQTT client
  Serial.println("Initialize MQTT client...");
  mqttClient.setServer(MQTTIP, PORT);
  mqttClient.setCallback(Callback);
  Serial.println("MQTT client initialized!");

  digitalWrite(LED_BUILTIN, LOW);
  digitalWrite(LED_PIN, HIGH);
  
  tone(13, 4000, 50);
  delay(200);
  tone(13, 2000, 100);
  delay(200);
  tone(13, 2000, 100);
}

void sendMessage(String content) {
 if (mqttClient.connected()) {
    // Convert String to char array
    char payloadCharArray[content.length() + 1]; // +1 for the null terminator
    content.toCharArray(payloadCharArray, sizeof(payloadCharArray));

    // Cast char array to uint8_t*
    const uint8_t* payloadUint8 = reinterpret_cast<const uint8_t*>(payloadCharArray);

    // Calculate payload length
    unsigned int payloadLength = content.length();

    // Publish the message
    if(mqttClient.publish(SUBTOPIC, payloadUint8, payloadLength, false)) {
      Serial.println("MQTT Message sent!");
    } else {
      Serial.println("Error sending MQTT message!");
    }
 } else {
    ReconnectMQTT();
 }
}

void loop() {
  button.loop(); // Must call the loop function in your main loop
  
  if(button.isPressed()){
    Serial.print("Button was pressed... ");
    if(digitalRead(LED_PIN) == HIGH){
      toggleLamp(false);
      Serial.println("LED off!");
    } else {
      toggleLamp(true);
      Serial.println("LED on!");
    }
  }

  if(!mqttClient.connected()){
    ReconnectMQTT();
  }
  mqttClient.loop();
}
 
void Callback(char* topic, byte* payload, unsigned int length){
  Message = "";
  for(int i = 0; i < length; i++){
    Message += ((char)payload[i]);
  }
  ParseMessage(Message);
}
 
void ReconnectMQTT(){
  while(!mqttClient.connected()) {
    Serial.println("Log in on MQTT broker");
    if(mqttClient.connect(CLIENTNAME)){
      Serial.println("Connected to MQTT broker!");
      Serial.println("Subscribe-Topic: '" SUBTOPIC "'");
      mqttClient.subscribe(SUBTOPIC, 1);
      digitalWrite(LED_BUILTIN, LOW);
      sendMessage(CLIENTNAME " is online!");
    } else {
      Serial.println("Timeout. Next attempt in 3 seconds...");
      digitalWrite(LED_BUILTIN, LOW);
      delay(1500);
      digitalWrite(LED_BUILTIN, HIGH);
      delay(1500);
    }
  }
}

/*
  Parse message:
  Gets an input string and performs the corresponding action

  Exmaple:
  ParseMessage(CLIENTNAME " lamp 1");
    => turn on the LED
*/
void ParseMessage(String message){
  Serial.println("Incoming message: " + message);
  int spaceIndex = message.indexOf(' ');
  String firstWord = message.substring(0, spaceIndex);
  message = message.substring(spaceIndex + 1);

  spaceIndex = message.indexOf(' ');
  String secondWord = message.substring(0, spaceIndex);
  String thirdWord = message.substring(spaceIndex + 1);

  if (firstWord == CLIENTNAME) {
    if (secondWord == "alarm") {
      if (thirdWord == "1") {
        alarmIsActive = true;
        playAlarm();
      } else if (thirdWord == "0") {
        alarmIsActive = false;
      }
    }
 }

 if (secondWord == "lamp") {
    if (thirdWord == "0") {
      toggleLamp(false);
    } else if (thirdWord == "1") {
      toggleLamp(true);
    } else if (thirdWord == "ESP8266_ALARMANLAGE") {
      String fourthWord = message.substring(message.indexOf(' ') + 1);
      if (fourthWord == "0") {
        Serial.println("Lampe auf ESP8266_ALARMANLAGE aus");
        toggleLamp(false);
      } else if (fourthWord == "1") {
        Serial.println("Lampe auf ESP8266_ALARMANLAGE an");
        toggleLamp(true);
      }
    }
 }

 delay(1000); // Wait for a second before the next loop iteration

 // Re-establish a connection to the broker, if needed
 if(!mqttClient.connected()){
    ReconnectMQTT();
 }
}

void toggleLamp(boolean turnOn) {
  tone(SPEAKER, 500, 100);
  if(turnOn) 
      digitalWrite(LED_PIN, HIGH);
  else
      digitalWrite(LED_PIN, LOW);
}

void playAlarm() {
  while (alarmIsActive) {
    tone(SPEAKER, 2000, 1000);
    delay(1000);
    tone(SPEAKER, 4000, 1000);
    delay(1000);

    // Check, if broker is 
    if(!mqttClient.connected()){
      ReconnectMQTT();
    }
    
    mqttClient.loop(); // Get newest message(s) to call the parse function
  }
}
