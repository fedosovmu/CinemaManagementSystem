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
        public NetConnection Connection;
        public BusinessModelManager ModelManager;
        bool AdminMod;

        public MainForm(NetConnection connection)
        {
            Connection = connection;
            ModelManager = new BusinessModelManager(connection);
            InitializeComponent();
        }



        public void EventsInitialization()
        {
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
                var filmDescriptionForm = new FilmDescriptionForm(AdminMod, Connection);
                filmDescriptionForm.Show();
            };

            EditFilmButton.Click += (a, e) =>
            {
                var filmDescriptionForm = new FilmDescriptionForm(AdminMod, Connection);
                filmDescriptionForm.Show();
                filmDescriptionForm.EditButton.PerformClick();
            };           

            DisconnectButton.Click += (a, e) =>
            {
                Close();
            };

            this.FormClosed += (a, e) =>
            {
                Connection.Disconnect();
            };

            // <--------

            ModelManager.MoviesChanged += () =>
            {
                FilmsListBox.Items.Clear();
                foreach(var Movie in ModelManager.Movies)
                {
                    FilmsListBox.Items.Add(Movie.Name);
                }
            };
        }
    }
}
