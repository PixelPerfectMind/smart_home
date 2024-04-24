using SmartHomeControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartHomeControl
{
    public class MqttConnection
    {
        private static MqttConnection _Instance { get; set; }

        /// <summary>
        /// Singleton instance of the MqttConnection class
        /// </summary>
        public static MqttConnection Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MqttConnection();
                }
                return _Instance;
            }
        }

        private static string _BrokerAddress { get; set; }

        /// <summary>
        /// Sets the MQTT broker address
        /// </summary>
        public void SetBrokerAddress(string brokerAddress)
        {
            _BrokerAddress = brokerAddress;
        }

        /// <summary>
        /// Returns the string value of the MQTT broker address
        /// </summary>
        public string GetBrokerAddress()
        {
            return _BrokerAddress;
        }

        private int _BrokerPort { get; set; }

        public void SetBrokerPort(int port)
        {
            _BrokerPort = port;
        }

        public int GetBrokerPort()
        {
            return _BrokerPort;
        }

        private string _SubscribeTopic { get; set; }

        public string GetSubscribeTopic()
        {
            return _SubscribeTopic;
        }

        public void SetSubscrbeTopic(string subscrbeTopic)
        {
            _SubscribeTopic = subscrbeTopic;
        }

        private string _ClientId { get; set; }

        public string GetClientId()
        {
            return _ClientId;
        }

        public void SetClientId(string clientId)
        {
            if(clientId == null || clientId == "")
            {
                _ClientId = Guid.NewGuid().ToString();
                return;
            }
            _ClientId = clientId;
        }

        private List<string> _Messages = new List<string>();

        public List<String> GetMessages()
        {
            return _Messages;
        }

        public void ClearMessages()
        {
            _Messages.Clear();
        }

        private MqttClient _MqttClient;

        public async Task InitializeMqttClient()
        {
            await Task.Run(() => {
                MqttClient client = new MqttClient(_BrokerAddress, _BrokerPort, false, MqttSslProtocols.None, null, null);
                client.Connect(_ClientId);
                _MqttClient = client;
            });
        }

        public bool mqttClientIsConnected()
        {
            if (_MqttClient == null) return false;
            return _MqttClient.IsConnected;
        }

        /// <summary>
        /// Publishes a MQTT message
        /// </summary>
        public void PublishMessage(MqttMessage message)
        {
            _MqttClient.Publish(message.Topic, System.Text.Encoding.UTF8.GetBytes(message.Message));
        }

        public void Subscribe(string topic)
        {
            _MqttClient.MqttMsgPublishReceived += ReceiveMessage;
            _MqttClient.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
        }

        private void ReceiveMessage(object sender, MqttMsgPublishEventArgs e)
        {
            _ReceivedMqttMessages.Add(new MqttMessage(System.Text.Encoding.Default.GetString(e.Message), e.Topic));
        }

        private List<MqttMessage> _ReceivedMqttMessages = new List<MqttMessage>();

        public List<MqttMessage> RecentMqttMessages { get { return _ReceivedMqttMessages; } }

        public void DeleteRecentMessages()
        {
            _ReceivedMqttMessages.Clear();
        }

        public void Disconnect()
        {
            _MqttClient.Disconnect();
            _MqttClient = null;
        }
    }
}
