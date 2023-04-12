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
    public partial class Edit_Information : UserControl
    {
        string userName;
        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Edit_Information(string un)
        {
            InitializeComponent();
            userName = un;
        }

        private void Edit_Information_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connstr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Mobile,address,carID from userinfo where userName=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", userName);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_CarNumber.Text = dr[2].ToString();
                txt_MobileNum.Text = dr[0].ToString();
                txt_Add.Text = dr[1].ToString();

            }
            dr.Close();
        }
        // Edit Button
        private void metroTile1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update userInfo set Mobile = :mob , address= :a , carID = :c  where userName = :u ";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("mob", txt_MobileNum.Text);
            c.Parameters.Add("add", txt_Add.Text);
            c.Parameters.Add("carid", txt_CarNumber.Text);
            c.Parameters.Add("uname", userName);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("driver modified");
            }
        }
    }
}
