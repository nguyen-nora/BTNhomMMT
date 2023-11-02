using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClientTCP
{
    public partial class Group : Form
    {
        private ClientSender client;
        public string user;
        public TcpClient server;
        public Message messages = new Message("");
        public Group(ClientSender cs, string user)
        {
            InitializeComponent();
            this.client = cs;
            this.user = user;
        }
    }
}
