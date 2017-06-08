using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementSystemClient
{
    public partial class ConnectForm : Form
    {
        public ClientNet Connection;       

        public ConnectForm()
        {
            InitializeComponent();
            IpTextBox.Text = "127.0.0.1";

            ConnectButton.Click += (a, e) =>
            {
                connect(IpTextBox.Text);
            };

            AutoConnectButton.Click += (a, e) =>
            {
                //IpTextBox.Text = Dns.GetHostAddresses("fedosov.net.ru")[0].ToString();
                IpTextBox.Text = "192.168.0.103";
                connect(IpTextBox.Text);
            };

            this.Shown += (a, e) =>
            {
                AutoConnectButton.PerformClick(); // <-----
            };
        }

        private void connect(String ip)
        {
            try
            {
                Connection = new ClientNet(ip);
                this.Hide();

                var mainForm = new MainForm(Connection);
                Connection.Disconneted += () =>
                {
                    BeginInvoke(new Action(() => { this.Show(); mainForm.Close(); }));
                };
                mainForm.FormClosed += (a, e) =>
                {
                    if (!this.Visible)
                    {
                        //Connection.Disconnect();
                        this.Close();
                    }
                };
                mainForm.Show();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
