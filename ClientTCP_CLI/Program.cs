using System;
using System.Net.Sockets;
using System.Text;

namespace ClientTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientSender a = new ClientSender("127.0.0.1", 9050);
            a.RunLoop();
            Console.WriteLine("LMAO");
            while (true) {
                Console.ReadKey();
            }
        }
    }
}
