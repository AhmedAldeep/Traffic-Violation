using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace _19A
{
    public partial class mainAdmin : MetroFramework.Forms.MetroForm
    {
        public mainAdmin()
        {
            InitializeComponent();
        }

        private void mainAdmin_Load(object sender, EventArgs e)
        {

        }
        // Sign OUt
        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form1 M = new Form1();
            ((Form)this.TopLevelControl).Hide();
            M.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }
        // Exit Button
        private void metroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // seeViolation
        private void btn_seeViolation_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel_mainAdmin.Controls)
            {
                ctrl.Dispose();
            }
            panel_mainAdmin.Controls.Add(new My_Violations("admin"));
        }
        // Set Violation
        private void btn_setViolation_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel_mainAdmin.Controls)
            {
                ctrl.Dispose();
            }
            panel_mainAdmin.Controls.Add(new Set_Violation());
        }
        //Responed complain
        private void btn_responedComplain_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel_mainAdmin.Controls)
            {
                ctrl.Dispose();
            }
            panel_mainAdmin.Controls.Add(new Responed_complain());
        }
    }
}
