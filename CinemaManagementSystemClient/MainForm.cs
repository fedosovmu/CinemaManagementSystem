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
            InitializeComponent();          

            AdminModeButton.Click += (a, e) =>
            {
                AddFilmButton.Enabled = true;
                EditFilmButton.Enabled = true;
                AddShowButton.Enabled = true;
                EditShowButton.Enabled = true;
                AdminMod = true;
            };

            FilmDescriptionButton.Click += (a, e) =>
            {
                var filmDescriptionForm = new FilmDescriptionForm(AdminMod);
                filmDescriptionForm.Show();
            };

            EditFilmButton.Click += (a, e) =>
            {
                var filmDescriptionForm = new FilmDescriptionForm(AdminMod);
                filmDescriptionForm.Show();
                filmDescriptionForm.EditButton.PerformClick();
            };

            DisconnectButton.Click += (a, e) =>
            {
                this.Close();
                
            };
        }
    }
}
