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
    public partial class MainForm : Form
    {
        public ClientNet Connection;
        bool AdminMod;

        public MainForm(ClientNet connection)
        {
            Connection = connection;
            InitializeComponent();

            AdminModeButton.Click += (a, e) =>
            {
                AddFilmButton.Enabled = true;
                EditFilmButton.Enabled = true;
                AddShowButton.Enabled = true;
                EditShowButton.Enabled = true;
                AdminMod = true;

                Connection.SendMessage("AdminMode#123");
            };

            FilmDescriptionButton.Click += (a, e) =>
            {
                var filmDescriptionForm = new FilmDescriptionForm(AdminMod, connection);
                filmDescriptionForm.Show();
            };

            EditFilmButton.Click += (a, e) =>
            {
                var filmDescriptionForm = new FilmDescriptionForm(AdminMod, connection);
                filmDescriptionForm.Show();
                filmDescriptionForm.EditButton.PerformClick();
            };

            Connection.MsgRecievedEvent += (message) =>
            {
                BeginInvoke(new Action(() => DebuggingRichTextBox.AppendText(message + "\n")));             
            };

            DisconnectButton.Click += (a, e) =>
            {
                Close();
            };

            this.FormClosed += (a, e) =>
            {
                Connection.Disconnect();
            };
        }
    }
}
