using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ClientTCP
{
    public partial class MainForm : Form
    {
        private ClientSender client;
        public string user;
        public TcpClient server;
        public List<string> users;
        public Dictionary<string, List<string>> groups;
        public Message messages = new Message("");
        public MainForm(ClientSender cs, string user)
        {
            InitializeComponent();
            this.client = cs;
            this.user = user;
        }


        private async void butSend_Click(object sender, EventArgs e)
        {
            string messenger = txtMess.Text.ToString();
            Message msg = new Message(messenger, user);
            await client.SendMessage(msg);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RunReceiveLoop();
            client.SendMessage(new Message("","@users_request"));
            client.SendMessage(new Message("","@groups_request"));
        }


        public async virtual void RunReceiveLoop()
        {
            try
            {
                while (true)
                {
                    Message msg = await client.ReceiveMessage();
                    switch (msg.sender)
                    {
                        case "@users_response":
                            users = new List<string>(msg.msg.Split(';'));
                            break;
                        case "@groups_response":
                            groups = new Dictionary<string, List<string>>();
                            foreach (string i in msg.msg.Split('\n'))
                            {
                                string[] k = i.Split(':');
                                string name = k[0];
                                List<string> members = new List<string>(k);
                                members.RemoveAt(0);
                                groups.Add(name, members);
                            }
                            break;
                        default:
                            txtViewMess.Text += msg.sender + ": " + msg.msg + Environment.NewLine;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("null");
            }
        }

        private void butRoom_Click(object sender, EventArgs e)
        {
            Group groupForm = new Group(client, user, users, groups);
            groupForm.ShowDialog();
            //this.Close();
        }
    }
}
    