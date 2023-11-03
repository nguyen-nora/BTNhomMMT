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
        public List<string> users;
        public Dictionary<string, List<string>> groups;
        public Group(ClientSender cs, string user, List<string> users, Dictionary<string, List<string>> groups)
        {
            InitializeComponent();
            this.client = cs;
            this.user = user;
            this.users = users;
            this.groups = groups;
        }

        private void Group_Load(object sender, EventArgs e)
        {
            foreach(string i in users)
            {
                lvClient.Items.Add(i);
            }
            txtViewChat.Clear();
            foreach(string i in groups.Keys)
            {
                txtViewChat.AppendText(i + Environment.NewLine);
            }
        }
    }
}
