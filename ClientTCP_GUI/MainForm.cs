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
            txtViewMess.Text = "Hello";
            RunReceiveLoop();
        }


        public async virtual void RunReceiveLoop()
        {
            try
            {
                while (true)
                {
                    Message msg = await client.ReceiveMessage();
                    txtViewMess.Text += msg.sender + ": " + msg.msg + "\n";
                }
            }
            catch (Exception)
            {
                Console.WriteLine("null");
            }
        }

        private void butRoom_Click(object sender, EventArgs e)
        {
            Group groupForm = new Group(client, user);
            groupForm.ShowDialog();
            //this.Close();
        }
    }
}
    