using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                Connection = new ClientNet(IpTextBox.Text, 42);
            };
        }
    }
}
