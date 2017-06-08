namespace CinemaManagementSystemClient
{
    partial class FilmDescriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilmDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FilmNameLable = new System.Windows.Forms.Label();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmNameTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmDescriptionRichTextBox
            // 
            this.FilmDescriptionRichTextBox.Location = new System.Drawing.Point(12, 50);
            this.FilmDescriptionRichTextBox.Name = "FilmDescriptionRichTextBox";
            this.FilmDescriptionRichTextBox.ReadOnly = true;
            this.FilmDescriptionRichTextBox.Size = new System.Drawing.Size(260, 220);
            this.FilmDescriptionRichTextBox.TabIndex = 0;
            this.FilmDescriptionRichTextBox.Text = "";
            // 
            // FilmNameLable
            // 
            this.FilmNameLable.AutoSize = true;
            this.FilmNameLable.Location = new System.Drawing.Point(12, 9);
            this.FilmNameLable.Name = "FilmNameLable";
            this.FilmNameLable.Size = new System.Drawing.Size(57, 13);
            this.FilmNameLable.TabIndex = 1;
            this.FilmNameLable.Text = "Название";
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(12, 34);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.FilmDescriptionLabel.TabIndex = 2;
            this.FilmDescriptionLabel.Text = "Описание";
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Location = new System.Drawing.Point(75, 9);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.ReadOnly = true;
            this.FilmNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.FilmNameTextBox.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 276);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(197, 276);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 276);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            // 
            // FilmDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 306);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FilmNameTextBox);
            this.Controls.Add(this.FilmDescriptionLabel);
            this.Controls.Add(this.FilmNameLable);
            this.Controls.Add(this.FilmDescriptionRichTextBox);
            this.Name = "FilmDescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmDescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox FilmDescriptionRichTextBox;
        public System.Windows.Forms.Label FilmNameLable;
        public System.Windows.Forms.Label FilmDescriptionLabel;
        public System.Windows.Forms.TextBox FilmNameTextBox;
        public System.Windows.Forms.Button EditButton;
        public System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Button SaveButton;
    }
}