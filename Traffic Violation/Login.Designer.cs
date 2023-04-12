namespace _19A
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_Driver = new MetroFramework.Controls.MetroTile();
            this.txt_userpw_login = new MetroFramework.Controls.MetroTextBox();
            this.txt_un_login = new MetroFramework.Controls.MetroTextBox();
            this.btn_Admin = new MetroFramework.Controls.MetroTile();
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
            this.pictureBox1.TabIndex = 17;
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
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Login";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btn_Driver
            // 
            this.btn_Driver.ActiveControl = null;
            this.btn_Driver.Location = new System.Drawing.Point(410, 214);
            this.btn_Driver.Name = "btn_Driver";
            this.btn_Driver.Size = new System.Drawing.Size(197, 41);
            this.btn_Driver.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Driver.TabIndex = 20;
            this.btn_Driver.Text = "Driver";
            this.btn_Driver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Driver.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Driver.UseSelectable = true;
            this.btn_Driver.Click += new System.EventHandler(this.btn_Driver_Click);
            // 
            // txt_userpw_login
            // 
            // 
            // 
            // 
            this.txt_userpw_login.CustomButton.Image = null;
            this.txt_userpw_login.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txt_userpw_login.CustomButton.Name = "";
            this.txt_userpw_login.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txt_userpw_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_userpw_login.CustomButton.TabIndex = 1;
            this.txt_userpw_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_userpw_login.CustomButton.UseSelectable = true;
            this.txt_userpw_login.CustomButton.Visible = false;
            this.txt_userpw_login.Lines = new string[0];
            this.txt_userpw_login.Location = new System.Drawing.Point(188, 214);
            this.txt_userpw_login.MaxLength = 32767;
            this.txt_userpw_login.Name = "txt_userpw_login";
            this.txt_userpw_login.PasswordChar = '*';
            this.txt_userpw_login.PromptText = "Password";
            this.txt_userpw_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userpw_login.SelectedText = "";
            this.txt_userpw_login.SelectionLength = 0;
            this.txt_userpw_login.SelectionStart = 0;
            this.txt_userpw_login.ShortcutsEnabled = true;
            this.txt_userpw_login.Size = new System.Drawing.Size(197, 41);
            this.txt_userpw_login.Style = MetroFramework.MetroColorStyle.Purple;
            this.txt_userpw_login.TabIndex = 19;
            this.txt_userpw_login.UseSelectable = true;
            this.txt_userpw_login.WaterMark = "Password";
            this.txt_userpw_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_userpw_login.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_un_login
            // 
            // 
            // 
            // 
            this.txt_un_login.CustomButton.Image = null;
            this.txt_un_login.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txt_un_login.CustomButton.Name = "";
            this.txt_un_login.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txt_un_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_un_login.CustomButton.TabIndex = 1;
            this.txt_un_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_un_login.CustomButton.UseSelectable = true;
            this.txt_un_login.CustomButton.Visible = false;
            this.txt_un_login.Lines = new string[0];
            this.txt_un_login.Location = new System.Drawing.Point(188, 167);
            this.txt_un_login.MaxLength = 32767;
            this.txt_un_login.Name = "txt_un_login";
            this.txt_un_login.PasswordChar = '\0';
            this.txt_un_login.PromptText = "UserName";
            this.txt_un_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_un_login.SelectedText = "";
            this.txt_un_login.SelectionLength = 0;
            this.txt_un_login.SelectionStart = 0;
            this.txt_un_login.ShortcutsEnabled = true;
            this.txt_un_login.Size = new System.Drawing.Size(197, 41);
            this.txt_un_login.Style = MetroFramework.MetroColorStyle.Purple;
            this.txt_un_login.TabIndex = 18;
            this.txt_un_login.UseSelectable = true;
            this.txt_un_login.WaterMark = "UserName";
            this.txt_un_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_un_login.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Admin
            // 
            this.btn_Admin.ActiveControl = null;
            this.btn_Admin.Location = new System.Drawing.Point(410, 167);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(197, 41);
            this.btn_Admin.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_Admin.TabIndex = 21;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Admin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Admin.UseSelectable = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Driver);
            this.Controls.Add(this.txt_userpw_login);
            this.Controls.Add(this.txt_un_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(784, 433);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_Driver;
        private MetroFramework.Controls.MetroTextBox txt_userpw_login;
        private MetroFramework.Controls.MetroTextBox txt_un_login;
        private MetroFramework.Controls.MetroTile btn_Admin;
    }
}
