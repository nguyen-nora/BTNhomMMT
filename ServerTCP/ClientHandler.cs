using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServerTCP
{
    class ClientHandler
    {
        private TcpListener server;
        private List<User> users;
        private List<Group> groups;
        private Authenticator auth;
        private Queue<Message> queue;
        public ClientHandler(int port)
        {
            server = new TcpListener(IPAddress.Any, port);
            users = new List<User>();
            groups = new List<Group>();
            auth = new Authenticator("../../../userinfo.txt");
            queue = new Queue<Message>();
        }
        public void RunLoop()
        {
            Handle();
            RunManager();
        }
        public void RunManager()
        {
            while (true)
            {
                string str = Console.ReadLine();
                switch (str.Split()[0])
                {
                    case "users":
                        foreach(User i in users)
                        {
                            Console.WriteLine("  " + i.username);
                        }
                        break;
                    case "groups":
                        foreach(Group i in groups)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "broadcast":
                        Message msg = new Message(str[(str.Split()[0].Length + 1)..], "");
                        Broadcast(msg);
                        break;
                    default:
                        break;
                }
            }
        }
        public async void Handle()
        {
            try
            {
                server.Start();
                Console.WriteLine("Dang cho client...");

                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    HandleClient(client);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Dang dung server...");
                server.Stop();
            }
        }
        public async void HandleClient(TcpClient client)
        {
            User u = null;
            try
            {
                IPEndPoint remoteEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                Console.WriteLine("Connected to " + remoteEndPoint.Address + ":" + remoteEndPoint.Port);
                await using NetworkStream ns = client.GetStream();
                while (true)
                {
                    u = await Authenticate(ns);
                    if(u != null)
                    {
                        break;
                    }
                    Console.WriteLine("Sai thong tin dang nhap!");
                }
                while (true)
                {
                    try
                    {
                        Message msg = await ReceiveMessage(u);
                        Console.WriteLine(u.username + ": " + msg);
                        if (msg.receivers == null)
                        {
                            await Broadcast(msg);
                        }
                        else
                        {
                            await SendMessage(u, msg);
                            foreach (string i in msg.receivers)
                            {
                                if (users.Find(k => k.username == i) != null)
                                {
                                    if (await SendMessage(u, msg))
                                    {
                                        continue;
                                    }
                                }
                                //Queue to file
                            }
                        }
                        /*
                        using (StreamWriter sw = new StreamWriter("export.txt"))
                        {
                            sw.WriteLine("{0};{1};{2};{3};{4}", emp.EmployeeID, emp.LastName, emp.FirstName, emp.YearsService, emp.Salary);
                        }
                        */

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ngat ket noi voi client");
                        ns.Close();
                        client.Close();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ngat ket noi voi client");
                client.Close();
            }
            finally
            {
                users.Remove(u);
            }
        }
        public async Task<User> Authenticate(NetworkStream ns)
        {
            User u = new User(ns);
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            Message msg = await ReceiveMessage(u);
            Dictionary<string, string> userkeys = JsonConvert.DeserializeObject<Dictionary<string, string>>(msg.jsonString);
            bool valid;
            if (users.Find(p => p.username.Equals(userkeys.GetValueOrDefault("username"))) != null)
            {
                valid = false;
            }
            else
            {
                valid = auth.IsValid(userkeys);
            }
            dict.Add("valid", valid);
            msg.jsonString = JsonConvert.SerializeObject(dict);
            await SendMessage(u, msg);
            if (valid)
            {
                u = new User(userkeys.GetValueOrDefault("username"), userkeys.GetValueOrDefault("password"));
                u.CreateSession(ns);
                users.Add(u);
            }
            return u;
            
        }
        public async Task<Message> ReceiveMessage(User u)
        {
            try
            {
                byte[] data = new byte[1024];
                byte[] size = new byte[2];
                int recv = await u.ns.ReadAsync(size, 0, 2);
                int packsize = BitConverter.ToInt16(size, 0);
                //Console.WriteLine("Kich thuoc goi tin = {0}", packsize);
                recv = await u.ns.ReadAsync(data, 0, packsize);
                return new Message(data, 0, recv);
            }
            catch (Exception)
            {
                Console.WriteLine("Ket noi bi gian doan!");
                return null;
            }
        }
        public async Task<bool> SendMessage(User u, Message msg)
        {
            try
            {
                byte[] data = msg.GetBytes();
                int size = msg.size;
                byte[] packsize = new byte[2];
                //Console.WriteLine("Kich thuoc goi tin = {0}", size);
                packsize = BitConverter.GetBytes(size);
                await u.ns.WriteAsync(packsize, 0, 2);
                await u.ns.WriteAsync(data, 0, size);
                u.ns.Flush();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Khong gui duoc: " + msg);
                return false;
            }
        }
        public async Task Broadcast(Message msg)
        {
            try
            {
                foreach(User u in users)
                {
                    await SendMessage(u, msg);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Khong gui duoc: " + msg);
            }
        }
    }
}