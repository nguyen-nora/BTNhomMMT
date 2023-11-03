using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace ServerTCP
{
    class User
    {
        public string username;
        public string password;
        public NetworkStream ns;

        public User(NetworkStream ns)
        {
            this.ns = ns;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public void CreateSession(NetworkStream ns)
        {
            this.ns = ns;
        }
    }
}
