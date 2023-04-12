using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace _19A
{
    public partial class Login : UserControl
    {
        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Login()
        {
            InitializeComponent();
        }
        // Admin 
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            if (txt_un_login.Text == "Admin" && txt_userpw_login.Text == "123")
            {
                mainAdmin M= new mainAdmin();
                ((Form)this.TopLevelControl).Hide();
                M.ShowDialog();
                ((Form)this.TopLevelControl).Close();
            }
            else
                MessageBox.Show("No username or password");
        }
        // Driver
        private void btn_Driver_Click(object sender, EventArgs e)
        {
            bool valid = false;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select userName , USERPW from userInfo";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr[0].ToString() == txt_un_login.Text && dr[1].ToString() == txt_userpw_login.Text)
                {
                    valid = true;
                }

            }
            if (!valid)
            {
                MessageBox.Show("The username or Password is not correct !");
            }
            dr.Close();
            if (valid)
            {
                main_user M = new main_user();
                ((Form)this.TopLevelControl).Hide();
                M.ShowDialog();
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connstr);
            conn.Open();
        }
    }
}
