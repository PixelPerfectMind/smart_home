#include <ezButton.h>
#include <ESP8266Wifi.h>
#include <PubSubClient.h>

//// Build configuration //////////////////////////////
// Set up the variables needed for the current build //
///////////////////////////////////////////////////////

#define CLIENT_NAME "ESP8266_Alarmanlage"       // MQTT client name
#define BROKER_IP "192.168.178.10"              // MQTT Broker IP address
#define BROKER_PORT 1883                        // MQTT Broker Port
#define BROKER_TOPIC "Alarmanlage"              // MQTT Broker Subscribe Topic
#define WIFI_SSID "S23 Ultra von Jonas"         // WIFI SSID
#define WIFI_PASSWORD "#*4ZgzSB"                // WIFI Password

static bool IS_IN_DEVLOPMENT = false;           // Defines, if the program is currently in development or in production,
                                                // to run specific code (e.g. shorter alarm for testing purposes).

static const int LED_POWER_SUPPLY = 7;          // Power supply pin for the LED
static const int ALARM_LOWTONE = 8;             // Power supply pin for the alarm
static const int ALARMBUTTON_POWERSUPPLY = 10;  // Power supply pin for the alarm trigger button
static const int ALARMBUTTON_INPUT = 11;        // Input pin for the alarm trigger button

ezButton alarmButton(ALARMBUTTON_INPUT);        // Create an instance of ezButton with the corresponding button

WiFiClient espClient;
PubSubClient mqttClient(espClient);

void setup() {
  // Set the Pins
  pinMode(LED_POWER_SUPPLY, OUTPUT);
  pinMode(ALARM_LOWTONE, OUTPUT);
  pinMode(ALARMBUTTON_POWERSUPPLY, OUTPUT);

  // Toggle pins
  digitalWrite(LED_POWER_SUPPLY, HIGH);
  digitalWrite(ALARM_LOWTONE, LOW);
  digitalWrite(ALARMBUTTON_POWERSUPPLY, HIGH);
  
  alarmButton.setDebounceTime(50);              // Set alarm button debounce time
  
  tone(8, 4000, 80);
  delay(250);
  tone(8, 2000, 100);
  delay(250);
  tone(8, 2000, 100);
  delay(100);
}

void loop() {
  alarmButton.loop(); // Call the loop method of ezButton 
  // Check if the button is pressed
  if (alarmButton.isPressed()) {
    TriggerAlarm();
  }
}

/// Play the alarm sound
void TriggerAlarm() {
  if(IS_IN_DEVLOPMENT) {
    tone(8, 500, 50);
    delay(50);
    tone(8, 2000, 50);
  } else {
    for(int i = 0; i < 3; i++) {
      tone(8, 1000, 1000);
      delay(1000);
      tone(8, 2000, 1000);
      delay(1000);
    }
  }
}
