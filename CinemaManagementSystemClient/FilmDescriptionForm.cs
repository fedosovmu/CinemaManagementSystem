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
    public partial class FilmDescriptionForm : Form
    {
        public FilmDescriptionForm(bool adminMod, NetConnection connection)
        {
            InitializeComponent();

            EditButton.Enabled = adminMod;

            ExitButton.Click += (a, e) =>
            {
                this.Close();
            };

            EditButton.Click += (a, e) =>
            {
                FilmNameTextBox.ReadOnly = false;
                FilmDescriptionRichTextBox.ReadOnly = false;
                SaveButton.Visible = true;
                EditButton.Visible = false;
            };

            SaveButton.Click += (a, e) =>
            {
                FilmNameTextBox.ReadOnly = true;
                FilmDescriptionRichTextBox.ReadOnly = true;
                SaveButton.Visible = false;
                EditButton.Visible = true;

                connection.SendMessage("EditFilm#" + FilmNameTextBox.Text 
                                      + "#" + FilmDescriptionRichTextBox.Text);
            };
        }
    }
}
