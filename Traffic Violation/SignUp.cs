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
    public partial class SignUp : UserControl
    {

        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public SignUp()
        {
            InitializeComponent();
        }
        // Sign Up
        private void metroTile1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select userName from userInfo";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr[0].ToString() == txt_un.Text)
                {
                    MessageBox.Show("enter another user name");
                    valid = false;
                }
            }
            dr.Close();



            ///////////////////////////////////////////////

            if (valid)
            {
                cmd.CommandText = "insert into userInfo values (:userN,:fn,:ln,:userP,:Mob,:addr,:cID)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("userN", txt_un.Text);
                cmd.Parameters.Add("fn", txt_fn.Text);
                cmd.Parameters.Add("ln", txt_ln.Text);
                cmd.Parameters.Add("userP", txt_up.Text);
                cmd.Parameters.Add("Mob", txt_PN.Text);
                cmd.Parameters.Add("addr", txt_add.Text);
                cmd.Parameters.Add("cID", txt_CarN.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("signed up correctly !");
            }

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connstr);
            conn.Open();
        }
    }
}
