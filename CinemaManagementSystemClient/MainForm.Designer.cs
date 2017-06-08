namespace CinemaManagementSystemClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminModeButton = new System.Windows.Forms.Button();
            this.AddShowButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.EditShowButton = new System.Windows.Forms.Button();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.EditFilmButton = new System.Windows.Forms.Button();
            this.FilmDescriptionButton = new System.Windows.Forms.Button();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.ShowsListBox = new System.Windows.Forms.ListBox();
            this.FilmListLabel = new System.Windows.Forms.Label();
            this.ShowsListLabel = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.DebuggingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AdminModeButton
            // 
            this.AdminModeButton.Location = new System.Drawing.Point(432, 2);
            this.AdminModeButton.Name = "AdminModeButton";
            this.AdminModeButton.Size = new System.Drawing.Size(75, 23);
            this.AdminModeButton.TabIndex = 0;
            this.AdminModeButton.Text = "Admin mode";
            this.AdminModeButton.UseVisualStyleBackColor = true;
            // 
            // AddShowButton
            // 
            this.AddShowButton.Enabled = false;
            this.AddShowButton.Location = new System.Drawing.Point(265, 347);
            this.AddShowButton.Name = "AddShowButton";
            this.AddShowButton.Size = new System.Drawing.Size(75, 23);
            this.AddShowButton.TabIndex = 2;
            this.AddShowButton.Text = "Add";
            this.AddShowButton.UseVisualStyleBackColor = true;
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(432, 347);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(75, 23);
            this.BookingButton.TabIndex = 3;
            this.BookingButton.Text = "Booking";
            this.BookingButton.UseVisualStyleBackColor = true;
            // 
            // EditShowButton
            // 
            this.EditShowButton.Enabled = false;
            this.EditShowButton.Location = new System.Drawing.Point(346, 347);
            this.EditShowButton.Name = "EditShowButton";
            this.EditShowButton.Size = new System.Drawing.Size(75, 23);
            this.EditShowButton.TabIndex = 6;
            this.EditShowButton.Text = "Edit";
            this.EditShowButton.UseVisualStyleBackColor = true;
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.Enabled = false;
            this.AddFilmButton.Location = new System.Drawing.Point(12, 347);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilmButton.TabIndex = 8;
            this.AddFilmButton.Text = "Add";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            // 
            // EditFilmButton
            // 
            this.EditFilmButton.Enabled = false;
            this.EditFilmButton.Location = new System.Drawing.Point(93, 347);
            this.EditFilmButton.Name = "EditFilmButton";
            this.EditFilmButton.Size = new System.Drawing.Size(75, 23);
            this.EditFilmButton.TabIndex = 9;
            this.EditFilmButton.Text = "Edit";
            this.EditFilmButton.UseVisualStyleBackColor = true;
            // 
            // FilmDescriptionButton
            // 
            this.FilmDescriptionButton.Location = new System.Drawing.Point(174, 347);
            this.FilmDescriptionButton.Name = "FilmDescriptionButton";
            this.FilmDescriptionButton.Size = new System.Drawing.Size(75, 23);
            this.FilmDescriptionButton.TabIndex = 10;
            this.FilmDescriptionButton.Text = "Description";
            this.FilmDescriptionButton.UseVisualStyleBackColor = true;
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(12, 31);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(237, 303);
            this.FilmsListBox.TabIndex = 13;
            // 
            // ShowsListBox
            // 
            this.ShowsListBox.FormattingEnabled = true;
            this.ShowsListBox.Location = new System.Drawing.Point(265, 31);
            this.ShowsListBox.Name = "ShowsListBox";
            this.ShowsListBox.Size = new System.Drawing.Size(242, 303);
            this.ShowsListBox.TabIndex = 14;
            // 
            // FilmListLabel
            // 
            this.FilmListLabel.AutoSize = true;
            this.FilmListLabel.Location = new System.Drawing.Point(12, 15);
            this.FilmListLabel.Name = "FilmListLabel";
            this.FilmListLabel.Size = new System.Drawing.Size(52, 13);
            this.FilmListLabel.TabIndex = 15;
            this.FilmListLabel.Text = "Фильмы";
            // 
            // ShowsListLabel
            // 
            this.ShowsListLabel.AutoSize = true;
            this.ShowsListLabel.Location = new System.Drawing.Point(262, 12);
            this.ShowsListLabel.Name = "ShowsListLabel";
            this.ShowsListLabel.Size = new System.Drawing.Size(47, 13);
            this.ShowsListLabel.TabIndex = 16;
            this.ShowsListLabel.Text = "Показы";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(351, 2);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 17;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // DebuggingRichTextBox
            // 
            this.DebuggingRichTextBox.Location = new System.Drawing.Point(513, 4);
            this.DebuggingRichTextBox.Name = "DebuggingRichTextBox";
            this.DebuggingRichTextBox.ReadOnly = true;
            this.DebuggingRichTextBox.Size = new System.Drawing.Size(209, 360);
            this.DebuggingRichTextBox.TabIndex = 18;
            this.DebuggingRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.DebuggingRichTextBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ShowsListLabel);
            this.Controls.Add(this.FilmListLabel);
            this.Controls.Add(this.ShowsListBox);
            this.Controls.Add(this.FilmsListBox);
            this.Controls.Add(this.FilmDescriptionButton);
            this.Controls.Add(this.EditFilmButton);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.EditShowButton);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.AddShowButton);
            this.Controls.Add(this.AdminModeButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button AdminModeButton;
        public System.Windows.Forms.Button AddShowButton;
        public System.Windows.Forms.Button BookingButton;
        public System.Windows.Forms.Button EditShowButton;
        public System.Windows.Forms.Button AddFilmButton;
        public System.Windows.Forms.Button EditFilmButton;
        public System.Windows.Forms.Button FilmDescriptionButton;
        public System.Windows.Forms.ListBox FilmsListBox;
        public System.Windows.Forms.ListBox ShowsListBox;
        public System.Windows.Forms.Label FilmListLabel;
        public System.Windows.Forms.Label ShowsListLabel;
        public System.Windows.Forms.Button DisconnectButton;
        public System.Windows.Forms.RichTextBox DebuggingRichTextBox;
    }
}

