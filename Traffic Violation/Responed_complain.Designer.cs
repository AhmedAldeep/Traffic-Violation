namespace _19A
{
    partial class Responed_complain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Responed_complain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmb_violationID = new MetroFramework.Controls.MetroComboBox();
            this.btn_responed = new MetroFramework.Controls.MetroTile();
            this.Rd_Accept = new MetroFramework.Controls.MetroRadioButton();
            this.Rd_Reject = new MetroFramework.Controls.MetroRadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            this.pictureBox1.TabIndex = 29;
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
            this.metroLabel1.Size = new System.Drawing.Size(233, 25);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Respond To The Complain";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cmb_violationID
            // 
            this.cmb_violationID.FormattingEnabled = true;
            this.cmb_violationID.ItemHeight = 23;
            this.cmb_violationID.Location = new System.Drawing.Point(300, 128);
            this.cmb_violationID.Name = "cmb_violationID";
            this.cmb_violationID.PromptText = "Violation ID";
            this.cmb_violationID.Size = new System.Drawing.Size(197, 29);
            this.cmb_violationID.Style = MetroFramework.MetroColorStyle.Green;
            this.cmb_violationID.TabIndex = 30;
            this.cmb_violationID.UseSelectable = true;
            // 
            // btn_responed
            // 
            this.btn_responed.ActiveControl = null;
            this.btn_responed.Location = new System.Drawing.Point(300, 271);
            this.btn_responed.Name = "btn_responed";
            this.btn_responed.Size = new System.Drawing.Size(197, 38);
            this.btn_responed.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_responed.TabIndex = 31;
            this.btn_responed.Text = "Responed";
            this.btn_responed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_responed.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_responed.UseSelectable = true;
            this.btn_responed.Click += new System.EventHandler(this.btn_responed_Click);
            // 
            // Rd_Accept
            // 
            this.Rd_Accept.AutoSize = true;
            this.Rd_Accept.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Rd_Accept.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.Rd_Accept.Location = new System.Drawing.Point(300, 192);
            this.Rd_Accept.Name = "Rd_Accept";
            this.Rd_Accept.Size = new System.Drawing.Size(72, 19);
            this.Rd_Accept.Style = MetroFramework.MetroColorStyle.Red;
            this.Rd_Accept.TabIndex = 34;
            this.Rd_Accept.Text = "Aceept";
            this.Rd_Accept.UseSelectable = true;
            // 
            // Rd_Reject
            // 
            this.Rd_Reject.AutoSize = true;
            this.Rd_Reject.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Rd_Reject.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.Rd_Reject.Location = new System.Drawing.Point(431, 192);
            this.Rd_Reject.Name = "Rd_Reject";
            this.Rd_Reject.Size = new System.Drawing.Size(66, 19);
            this.Rd_Reject.Style = MetroFramework.MetroColorStyle.Red;
            this.Rd_Reject.TabIndex = 35;
            this.Rd_Reject.Text = "Reject";
            this.Rd_Reject.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Responed_complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Rd_Reject);
            this.Controls.Add(this.Rd_Accept);
            this.Controls.Add(this.btn_responed);
            this.Controls.Add(this.cmb_violationID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Responed_complain";
            this.Size = new System.Drawing.Size(784, 433);
            this.Load += new System.EventHandler(this.Responed_complain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmb_violationID;
        private MetroFramework.Controls.MetroTile btn_responed;
        private MetroFramework.Controls.MetroRadioButton Rd_Accept;
        private MetroFramework.Controls.MetroRadioButton Rd_Reject;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
