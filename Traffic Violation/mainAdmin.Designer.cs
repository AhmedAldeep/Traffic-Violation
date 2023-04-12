namespace _19A
{
    partial class mainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_mainAdmin = new MetroFramework.Controls.MetroPanel();
            this.btn_responedComplain = new MetroFramework.Controls.MetroTile();
            this.btn_setViolation = new MetroFramework.Controls.MetroTile();
            this.btn_seeViolation = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel_mainAdmin
            // 
            this.panel_mainAdmin.HorizontalScrollbarBarColor = true;
            this.panel_mainAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_mainAdmin.HorizontalScrollbarSize = 10;
            this.panel_mainAdmin.Location = new System.Drawing.Point(219, 80);
            this.panel_mainAdmin.Name = "panel_mainAdmin";
            this.panel_mainAdmin.Size = new System.Drawing.Size(784, 433);
            this.panel_mainAdmin.TabIndex = 12;
            this.panel_mainAdmin.VerticalScrollbarBarColor = true;
            this.panel_mainAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.panel_mainAdmin.VerticalScrollbarSize = 10;
            // 
            // btn_responedComplain
            // 
            this.btn_responedComplain.ActiveControl = null;
            this.btn_responedComplain.Location = new System.Drawing.Point(23, 198);
            this.btn_responedComplain.Name = "btn_responedComplain";
            this.btn_responedComplain.Size = new System.Drawing.Size(190, 53);
            this.btn_responedComplain.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_responedComplain.TabIndex = 11;
            this.btn_responedComplain.Text = "Responed complain";
            this.btn_responedComplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_responedComplain.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_responedComplain.UseSelectable = true;
            this.btn_responedComplain.Click += new System.EventHandler(this.btn_responedComplain_Click);
            // 
            // btn_setViolation
            // 
            this.btn_setViolation.ActiveControl = null;
            this.btn_setViolation.Location = new System.Drawing.Point(23, 139);
            this.btn_setViolation.Name = "btn_setViolation";
            this.btn_setViolation.Size = new System.Drawing.Size(190, 53);
            this.btn_setViolation.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_setViolation.TabIndex = 10;
            this.btn_setViolation.Text = "Set violation";
            this.btn_setViolation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_setViolation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_setViolation.UseSelectable = true;
            this.btn_setViolation.Click += new System.EventHandler(this.btn_setViolation_Click);
            // 
            // btn_seeViolation
            // 
            this.btn_seeViolation.ActiveControl = null;
            this.btn_seeViolation.Location = new System.Drawing.Point(23, 80);
            this.btn_seeViolation.Name = "btn_seeViolation";
            this.btn_seeViolation.Size = new System.Drawing.Size(190, 53);
            this.btn_seeViolation.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_seeViolation.TabIndex = 9;
            this.btn_seeViolation.Text = "All violations";
            this.btn_seeViolation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_seeViolation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_seeViolation.UseSelectable = true;
            this.btn_seeViolation.Click += new System.EventHandler(this.btn_seeViolation_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 316);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(190, 53);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 14;
            this.metroTile1.Text = "Exit";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 257);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(190, 53);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "Sign Out";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 541);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.panel_mainAdmin);
            this.Controls.Add(this.btn_responedComplain);
            this.Controls.Add(this.btn_setViolation);
            this.Controls.Add(this.btn_seeViolation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainAdmin";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "         Traffic Violation";
            this.Load += new System.EventHandler(this.mainAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel panel_mainAdmin;
        private MetroFramework.Controls.MetroTile btn_responedComplain;
        private MetroFramework.Controls.MetroTile btn_setViolation;
        private MetroFramework.Controls.MetroTile btn_seeViolation;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}