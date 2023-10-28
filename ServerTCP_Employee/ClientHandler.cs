﻿using System;
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
        private Authenticator auth;
        private Queue<Message> queue;
        public ClientHandler(int port)
        {
            server = new TcpListener(IPAddress.Any, port);
            users = new List<User>();
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
                string[] str = Console.ReadLine().Split(' ');
                switch (str[0])
                {
                    case "show":
                        foreach(User i in users)
                        {
                            Console.WriteLine("  " + i.username);
                        }
                        break;
                    case "broadcast":
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
                Console.WriteLine("Ket noi voi client " + client.ToString());
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
                        Console.WriteLine(u.username + ':' + msg);
                        //queue.Enqueue(msg);
                        if (msg.receivers.Count == 0)
                        {
                            Broadcast(msg);
                        }
                        foreach(string i in msg.receivers)
                        {

                        }
                        await SendMessage(u, msg);
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
        public async Task SendMessage(User u, Message msg)
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
            }
            catch (Exception)
            {
                Console.WriteLine("Khong gui duoc: " + msg.jsonString);
            }
        }
    }
}
