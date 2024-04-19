using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
