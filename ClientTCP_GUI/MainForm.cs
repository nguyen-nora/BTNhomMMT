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
    }
}
