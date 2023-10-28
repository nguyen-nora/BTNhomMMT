using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ServerTCP
{
    class Message
    {
        public string msg;
        public string sender;
        public List<string> receivers;
        public DateTime time;
        public string jsonString;
        public int size;
        public Message(string jsonString)
        {
            this.jsonString = jsonString;
            size = jsonString.Length;
        }
        public Message(string msg, string sender, List<string> receivers)
        {
            this.msg = msg;
            this.sender = sender;
            this.receivers = receivers;
            time = DateTime.UtcNow;
            jsonString = Encode();
            size = jsonString.Length;
        }
        public Message(string msg, string sender)
        {
            this.msg = msg;
            this.sender = sender;
            receivers = new List<string>();
            time = DateTime.UtcNow;
            jsonString = Encode();
            size = jsonString.Length;
        }
        public Message(string msg, List<string> receivers)
        {
            this.msg = msg;
            sender = "";
            this.receivers = receivers;
            time = DateTime.UtcNow;
            jsonString = Encode();
            size = jsonString.Length;
        }
        public Message(byte[] data, int index, int count)
        {
            jsonString = Encoding.UTF8.GetString(data, index, count);
            size = jsonString.Length;
        }
        private string Encode()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("message", msg);
            dict.Add("sender", sender);
            dict.Add("receivers", receivers);
            dict.Add("time", time);
            return null;
        }
        public byte[] GetBytes()
        {
            byte[] data = new byte[1024];
            //Buffer.BlockCopy(BitConverter.GetBytes(JsonString.Length), 0, data, place, 4);
            //place += 4;
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(jsonString), 0, data, 0, jsonString.Length);
            size = jsonString.Length;
            return data;
        }
        public override string ToString()
        {
            return jsonString;
        }
    }
}
