using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClientTCP
{
    class ClientSender
    {
        private TcpClient server;
        private NetworkStream ns;

        public ClientSender(string ip, int port)
        {
            server = new TcpClient();
            Connect(ip, port);
        }
        public async void Connect(string ip, int port)
        {
            try
            {
                await server.ConnectAsync(ip, port);
                ns = server.GetStream();
            }
            catch (SocketException)
            {
                Console.WriteLine("Khong the ket noi duoc voi server");
                return;
            }
        }
        public async void Send()
        {
            string str;
            try
            {
                if (server.Connected)
                {
                    Console.WriteLine("Ket noi thanh cong");
                    while (true)
                    {
                        Console.Write("Nhap username: ");
                        string username = Console.ReadLine();
                        Console.Write("Nhap password: ");
                        string password = Console.ReadLine();
                        if (await Authenticate(username, password))
                        {
                            break;
                        }
                        Console.WriteLine("Sai thong tin dang nhap");
                    }
                    Console.WriteLine("Dang nhap thanh cong!");
                }
                while (true)
                {
                    str = Console.ReadLine();
                    if (str.Equals(""))
                    {
                        continue;
                    }
                    if (str.Equals("exit"))
                    {
                        Console.WriteLine("Ngat ket noi voi server...");
                        server.Close();
                    }
                    Message msg = new Message(str);
                    SendMessage(msg);

                    msg = await ReceiveMessage();
                    Console.WriteLine(msg);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ngat ket noi voi server...");
                server.Close();
            }
        }
        public async Task<bool> Authenticate(string username, string password)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("username", username);
            dict.Add("password", password);
            Message msg = new Message(JsonConvert.SerializeObject(dict));
            SendMessage(msg);
            msg = await ReceiveMessage();
            return JsonConvert.DeserializeObject<Dictionary<string, bool>>(msg.jsonString).GetValueOrDefault("valid", false);
        }
        public async void SendMessage(Message msg)
        {
            try
            {
                byte[] data = msg.GetBytes();
                int size = msg.size;
                byte[] packsize = new byte[2];
                //Console.WriteLine("Kich thuoc goi tin = {0}", size);
                packsize = BitConverter.GetBytes(size);
                await ns.WriteAsync(packsize, 0, 2);
                await ns.WriteAsync(data, 0, size);
                ns.Flush();
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to send message " + msg);
            }
        }
        public async Task<Message> ReceiveMessage()
        {
            try
            {
                byte[] data = new byte[1024];
                byte[] size = new byte[2];
                int recv = await ns.ReadAsync(size, 0, 2);
                int packsize = BitConverter.ToInt16(size, 0);
                //Console.WriteLine("Kich thuoc goi tin = {0}", packsize);
                recv = await ns.ReadAsync(data, 0, packsize);
                return new Message(data, 0, recv);
            }
            catch (Exception)
            {
                Console.WriteLine("Connection interrupted!");
                return null;
            }
        }
    }
}
