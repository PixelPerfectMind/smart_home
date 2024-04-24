using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeControl.Models
{
    public class MqttMessage
    {
        public MqttMessage() { }

        public MqttMessage(string message) { }

        public MqttMessage(string message, string topic)
        {
            this.Message = message;
            Topic = topic;
        }

        public string Message { get; set; }

        public string Topic { get; set; }
    }
}
