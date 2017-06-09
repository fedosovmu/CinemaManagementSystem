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
    public partial class AddFilmForm : Form
    {
        public AddFilmForm(NetConnection connection)
        {
            InitializeComponent();

            AddFilmButton.Click += (a, e) =>
            {
                connection.SendMessage("AddMovie#" + NameTextBox.Text + "#" + DescriptionRichTextBox.Text);
                this.Close();
            };
        }
    }
}
