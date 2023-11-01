using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Net;

namespace ClientTCP
{
    public partial class Login : Form
    {
        static ClientSender a = new ClientSender("127.0.0.1", 9050);
        private ClientSender client;
        public TcpClient server;
        public Login()
        {
            InitializeComponent();
            this.client = a;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string user = usrTBox.Text;
            string pwd = pwdTBox.Text;
            string username = null;
            username = await client.Login(user, pwd);
            if (username != null)
            {
                MainForm mainForm = new MainForm(client, username);
                mainForm.ShowDialog();
                this.Close();
            }
        }
    }
}
