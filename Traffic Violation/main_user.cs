using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19A
{
    public partial class main_user : MetroFramework.Forms.MetroForm
    {
        string userName;
        public main_user(string uN)
        {
            InitializeComponent();
            userName = uN;
        }

        private void main_user_Load(object sender, EventArgs e)
        {

        }
        // Sign Out
        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form1 M = new Form1();
            ((Form)this.TopLevelControl).Hide();
            M.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }
        // Exit
        private void metroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Edit Information
        private void btn_Einfo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Edit_Information(userName));
        }
        //My violations
        private void btn_myViolation_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new My_Violations(userName));
        }
        // Pay fees
        private void btn_PayF_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Pay_Fees(userName));
        }
        // Make a complain
        private void btn_complain_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Make_complain(userName));
        }
    }
}
