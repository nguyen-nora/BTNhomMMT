using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace ServerTCP
{
    class Authenticator
    {
        private Dictionary<string,string> users = new Dictionary<string, string>();
        public Authenticator(string file)
        {
            StreamReader sr = new StreamReader(file);
            string str = sr.ReadToEnd();
            foreach(string i in str.Split('\n'))
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(i);
                users.Add(dict.GetValueOrDefault("username"), dict.GetValueOrDefault("password"));
            }
            sr.Close();
        }
        public bool Exists(string username)
        {
            return users.ContainsKey(username);
        }
        public bool IsValid(Dictionary<string, string> dict)
        {
            string username = dict.GetValueOrDefault("username");
            if (Exists(username)){
                return users.GetValueOrDefault(username).Equals(dict.GetValueOrDefault("password"));
            }
            return false;
        }
    }
}
