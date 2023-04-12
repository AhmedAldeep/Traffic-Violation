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
    public partial class Pay_Fees : UserControl
    {
        string userName;
        string cid = "";
        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Pay_Fees(string un)
        {
            InitializeComponent();
            userName = un;
        }

        private void Pay_Fees_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connstr);
            conn.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select CARID from USERINFO where USERNAME=:un";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("un", userName);
            OracleDataReader d = c.ExecuteReader();
            while (d.Read())
                cid = d[0].ToString();
            d.Close();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select VIOLATIONID from VIOLATIONINFO where CARID=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cid);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmb_violationID.Items.Add(dr[0]);

            dr.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (cmb_Bank.Text != "" && txt_Card.Text != "" && txt_password.Text != "")
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "Delete from VIOLATIONINFO where VIOLATIONID=:id";
                c.Parameters.Add("id", cmb_violationID.Text);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Violation deleted");
                    cmb_violationID.Items.RemoveAt(cmb_violationID.SelectedIndex);
                }


            }
            else MessageBox.Show("Please Enter full information");
        }
    }
}
