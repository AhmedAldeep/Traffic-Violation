namespace _19A
{
    partial class Pay_Fees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Fees));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmb_violationID = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Bank = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.txt_Card = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(16)))), ((int)(((byte)(61)))));
            this.metroLabel1.Location = new System.Drawing.Point(63, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Pay Fees";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cmb_violationID
            // 
            this.cmb_violationID.FormattingEnabled = true;
            this.cmb_violationID.ItemHeight = 23;
            this.cmb_violationID.Location = new System.Drawing.Point(250, 96);
            this.cmb_violationID.Name = "cmb_violationID";
            this.cmb_violationID.PromptText = "Violation ID";
            this.cmb_violationID.Size = new System.Drawing.Size(279, 29);
            this.cmb_violationID.Style = MetroFramework.MetroColorStyle.Green;
            this.cmb_violationID.TabIndex = 24;
            this.cmb_violationID.UseSelectable = true;
            // 
            // cmb_Bank
            // 
            this.cmb_Bank.FormattingEnabled = true;
            this.cmb_Bank.ItemHeight = 23;
            this.cmb_Bank.Location = new System.Drawing.Point(250, 150);
            this.cmb_Bank.Name = "cmb_Bank";
            this.cmb_Bank.PromptText = "Choose Your Credit Card Bank";
            this.cmb_Bank.Size = new System.Drawing.Size(279, 29);
            this.cmb_Bank.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmb_Bank.TabIndex = 25;
            this.cmb_Bank.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(292, 341);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(197, 38);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 28;
            this.metroTile1.Text = "Confirm";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(250, 270);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PromptText = "Password";
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(279, 41);
            this.txt_password.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_password.TabIndex = 27;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMark = "Password";
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Card
            // 
            // 
            // 
            // 
            this.txt_Card.CustomButton.Image = null;
            this.txt_Card.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_Card.CustomButton.Name = "";
            this.txt_Card.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txt_Card.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Card.CustomButton.TabIndex = 1;
            this.txt_Card.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Card.CustomButton.UseSelectable = true;
            this.txt_Card.CustomButton.Visible = false;
            this.txt_Card.Lines = new string[0];
            this.txt_Card.Location = new System.Drawing.Point(250, 204);
            this.txt_Card.MaxLength = 32767;
            this.txt_Card.Name = "txt_Card";
            this.txt_Card.PasswordChar = '\0';
            this.txt_Card.PromptText = "Card";
            this.txt_Card.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Card.SelectedText = "";
            this.txt_Card.SelectionLength = 0;
            this.txt_Card.SelectionStart = 0;
            this.txt_Card.ShortcutsEnabled = true;
            this.txt_Card.Size = new System.Drawing.Size(279, 41);
            this.txt_Card.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_Card.TabIndex = 26;
            this.txt_Card.UseSelectable = true;
            this.txt_Card.WaterMark = "Card";
            this.txt_Card.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Card.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Pay_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Card);
            this.Controls.Add(this.cmb_Bank);
            this.Controls.Add(this.cmb_violationID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Pay_Fees";
            this.Size = new System.Drawing.Size(784, 433);
            this.Load += new System.EventHandler(this.Pay_Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmb_violationID;
        private MetroFramework.Controls.MetroComboBox cmb_Bank;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroTextBox txt_Card;
    }
}
