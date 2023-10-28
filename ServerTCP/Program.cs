using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ServerTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientHandler a = new ClientHandler(9050);
            a.RunLoop();
        }
    }
}
