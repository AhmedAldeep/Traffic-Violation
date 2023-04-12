namespace _19A
{
    partial class Make_complain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Make_complain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmb_violationID = new MetroFramework.Controls.MetroComboBox();
            this.txt_complainDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
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
            this.pictureBox1.TabIndex = 25;
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
            this.metroLabel1.Size = new System.Drawing.Size(162, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Make A Complain";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cmb_violationID
            // 
            this.cmb_violationID.FormattingEnabled = true;
            this.cmb_violationID.ItemHeight = 23;
            this.cmb_violationID.Location = new System.Drawing.Point(110, 122);
            this.cmb_violationID.Name = "cmb_violationID";
            this.cmb_violationID.PromptText = "Violation ID";
            this.cmb_violationID.Size = new System.Drawing.Size(279, 29);
            this.cmb_violationID.Style = MetroFramework.MetroColorStyle.Green;
            this.cmb_violationID.TabIndex = 26;
            this.cmb_violationID.UseSelectable = true;
            // 
            // txt_complainDesc
            // 
            // 
            // 
            // 
            this.txt_complainDesc.CustomButton.Image = null;
            this.txt_complainDesc.CustomButton.Location = new System.Drawing.Point(445, 2);
            this.txt_complainDesc.CustomButton.Name = "";
            this.txt_complainDesc.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.txt_complainDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_complainDesc.CustomButton.TabIndex = 1;
            this.txt_complainDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_complainDesc.CustomButton.UseSelectable = true;
            this.txt_complainDesc.CustomButton.Visible = false;
            this.txt_complainDesc.Lines = new string[0];
            this.txt_complainDesc.Location = new System.Drawing.Point(110, 178);
            this.txt_complainDesc.MaxLength = 32767;
            this.txt_complainDesc.Multiline = true;
            this.txt_complainDesc.Name = "txt_complainDesc";
            this.txt_complainDesc.PasswordChar = '\0';
            this.txt_complainDesc.PromptText = "Complain Description";
            this.txt_complainDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_complainDesc.SelectedText = "";
            this.txt_complainDesc.SelectionLength = 0;
            this.txt_complainDesc.SelectionStart = 0;
            this.txt_complainDesc.ShortcutsEnabled = true;
            this.txt_complainDesc.Size = new System.Drawing.Size(545, 102);
            this.txt_complainDesc.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_complainDesc.TabIndex = 27;
            this.txt_complainDesc.UseSelectable = true;
            this.txt_complainDesc.WaterMark = "Complain Description";
            this.txt_complainDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_complainDesc.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(458, 304);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(197, 38);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 29;
            this.metroTile1.Text = "Send";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Make_complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txt_complainDesc);
            this.Controls.Add(this.cmb_violationID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Make_complain";
            this.Size = new System.Drawing.Size(784, 433);
            this.Load += new System.EventHandler(this.Make_complain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmb_violationID;
        private MetroFramework.Controls.MetroTextBox txt_complainDesc;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
