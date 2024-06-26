#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <ezButton.h>
 
// Config
#define STASSID "S23 Ultra von Jonas"
#define STAPSK "#*4ZgzSB"
#define MQTTIP "192.168.95.29"
#define SUBTOPIC "SmartHome/SingleLed"
#define PORT 1883
#define CLIENTNAME "ESP8266_LEDREMOTE"
 
// GPIO Pins
const int BUTTON_PIN = 5;     // D1 on ESP8266
const int LED_PIN = 2;        // D4 on ESP8266
const int ALARM_BUTTON_PIN = 13;       // D7 on ESP8266

ezButton button(BUTTON_PIN); // ezButton on BUTTON_PIN;
ezButton alarm_button(ALARM_BUTTON_PIN); // ezButton on ALARM_BUTTON_PIN;
 
WiFiClient espClient;
PubSubClient mqttClient(espClient);
 
String Message;

// Device functions are running, or not
bool alarmIsActive = false;
bool lampIsActive = true;

/*
  The callback void is called, when a new MQTT message went in.
  The message comes in as a byte array and the contents will
  be converted into a string
*/
void Callback(char* topic, byte* payload, unsigned int length){
  // Clear previous message value
  Message = "";

  // For each character, add it to the Message string
  for(int i = 0; i < length; i++){
    Message += ((char)payload[i]);
  }
  parseMessage(Message);
}

/*
  This method is called, when the ESP8266 turns on.
  It is used to initialize some things
*/
void setup() {
  // Set internal LED
  pinMode(LED_BUILTIN, OUTPUT);
  
  button.setDebounceTime(50); // Set button debounce time to 50 milliseconds
  alarm_button.setDebounceTime(100); // Set button debounce time to 50 milliseconds
 
  Serial.begin(9600);
  delay(100);
  
  // Create WiFi conntection
  Serial.println("Connecting to WiFi...");
  WiFi.mode(WIFI_STA);
  WiFi.begin(STASSID, STAPSK);

  // Wait, until broker is connected to the WiFi
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
  Serial.println(WiFi.localIP()); // Print this device's IP address
  
  // Set up MQTT client
  Serial.println("Initialize MQTT client...");
  mqttClient.setServer(MQTTIP, PORT);
  mqttClient.setCallback(Callback);
  Serial.println("MQTT client initialized!");

  // Set pins to high or low
  digitalWrite(LED_BUILTIN, LOW);
  digitalWrite(LED_PIN, HIGH);

}

/*
  This method sends a MQTT message to the broker
*/
void sendMessage(String topic, String content) {
 if (mqttClient.connected()) {
    // Convert String to char array
    char payloadCharArray[content.length() + 1]; // +1 for the null terminator
    content.toCharArray(payloadCharArray, sizeof(payloadCharArray));

    // Cast char array to uint8_t*
    const uint8_t* payloadUint8 = reinterpret_cast<const uint8_t*>(payloadCharArray);

    // Calculate payload length
    unsigned int payloadLength = content.length();

    // Convert String topic to const char*
    const char* topicChar = topic.c_str();

    // Publish the message
    if(mqttClient.publish(topicChar, payloadUint8, payloadLength, false)) {
      Serial.println("MQTT Message sent!");
    } else {
      Serial.println("Error sending MQTT message!");
    }
 } else {
    reconnectMQTT();
 }
}


/*
  The loop void repeats infinitely on the Arduino / ESP.
  It checks for pressed buttons and new MQTT messages.
*/
void loop() {
  button.loop(); // Check, if the ezButton was pressed
  alarm_button.loop(); // Check, if the ezButton was pressed

  // Detect, if the button was pressed, if so, then toggle the LED pin
  if(button.isPressed()){
    Serial.print("Light toggle button was pressed... ");
    toggleLamp();
    if(lampIsActive) Serial.println("LED off!");
    else Serial.println("LED on!");
  }

  if(alarm_button.isPressed()){
    Serial.println("Alarm button was pressed.");
    sendMessage("SmartHome/AlarmSystem", "ESP8266_ALARMSYSTEM alarm");
  }

  // If needed, reconnect to the MQTT broker
  if(!mqttClient.connected()){
    reconnectMQTT();
  }
  mqttClient.loop(); // Check for new MQTT messages
}

/*
  While this client is not connected to the MQTT broker,
  this method trys to connect to the broker.
*/
void reconnectMQTT(){
  while(!mqttClient.connected()) {
    Serial.println("Log in on MQTT broker...");
    // Connect to broker
    if(mqttClient.connect(CLIENTNAME)){
      // When connected, resume with the other tasks
      Serial.println("Connected to MQTT broker!");
      Serial.println("Subscribe-Topic: '" SUBTOPIC "'");
      mqttClient.subscribe(SUBTOPIC, 1);
      digitalWrite(LED_BUILTIN, LOW);
      sendMessage(SUBTOPIC, CLIENTNAME " is online!");
    } else {
      // When not connected, let the LED blink slowly
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
void parseMessage(String message){
  Serial.println("Incoming message: " + message);
  int spaceIndex = message.indexOf(' ');
  String deviceName = message.substring(0, spaceIndex);
  message = message.substring(spaceIndex + 1);

  spaceIndex = message.indexOf(' ');
  String command = message.substring(0, spaceIndex);

  // When this client is called, run the command
  if (deviceName == CLIENTNAME) {

    // When to command is "lamp", toggle the LED pin.
    if (command == "lamp") toggleLamp();
  }

 delay(1000); // Wait for a second before the next loop iteration

 // Re-establish a connection to the broker, if needed
 if(!mqttClient.connected()){
    reconnectMQTT();
 }
}

/*
  Toggle the LED pin to high or low
*/
void toggleLamp() {
  if(lampIsActive) digitalWrite(LED_PIN, HIGH);
  else digitalWrite(LED_PIN, LOW);
  lampIsActive = !lampIsActive;
}
