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
    public partial class Make_complain : UserControl
    {
        string userName;
        string cid = "";
        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Make_complain(string un)
        {
            InitializeComponent();
            userName = un;
        }

        private void Make_complain_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select VIOLATIONID from VIOLATIONINFO where CARID=:id and STATUS is null";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cid);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmb_violationID.Items.Add(dr[0]);

            dr.Close();
        }
        // send button
        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (cmb_violationID.Text == "")
                MessageBox.Show("Please Choose violation id ");
            else
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update VIOLATIONINFO set COMPLAINDES=:comDes,status=:st where VIOLATIONID=:vid";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("comDes", txt_complainDesc.Text);
                cmd.Parameters.Add("st", "Not responded yet");
                cmd.Parameters.Add("vid", cmb_violationID.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Complaint Sent");




            }
        }
    }
}
