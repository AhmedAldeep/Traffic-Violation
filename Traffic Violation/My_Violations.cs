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
    public partial class My_Violations : UserControl
    {
        string username;
        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public My_Violations(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void My_Violations_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connstr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (username == "admin")
            {

                cmd.CommandText = "select * from VIOLATIONINFO";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    metroGrid1.Rows.Add();
                    metroGrid1.Rows[i].Cells[0].Value = dr[0].ToString();
                    metroGrid1.Rows[i].Cells[1].Value = dr[1].ToString();
                    metroGrid1.Rows[i].Cells[2].Value = dr[2].ToString();
                    metroGrid1.Rows[i].Cells[3].Value = dr[3].ToString();
                    metroGrid1.Rows[i].Cells[4].Value = dr[4].ToString();
                    metroGrid1.Rows[i].Cells[5].Value = dr[5].ToString();
                    if (dr[6].ToString() == "") metroGrid1.Rows[i].Cells[6].Value = "No Complain";
                    else metroGrid1.Rows[i].Cells[6].Value = dr[6].ToString();
                    metroGrid1.Rows[i].Cells[7].Value = dr[7].ToString();
                    i++;
                }
                dr.Close();


            }




            else
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select CARID from USERINFO where USERNAME =:un";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("un", username);
                OracleDataReader dread = c.ExecuteReader();
                while (dread.Read())
                {
                    string carid = dread[0].ToString();

                    cmd.CommandText = "select * from VIOLATIONINFO where CARID=:cid";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("cid", carid);
                    OracleDataReader dr = cmd.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        metroGrid1.Rows.Add();
                        metroGrid1.Rows[i].Cells[0].Value = dr[0].ToString();
                        metroGrid1.Rows[i].Cells[1].Value = dr[1].ToString();
                        metroGrid1.Rows[i].Cells[2].Value = dr[2].ToString();
                        metroGrid1.Rows[i].Cells[3].Value = dr[3].ToString();
                        metroGrid1.Rows[i].Cells[4].Value = dr[4].ToString();
                        metroGrid1.Rows[i].Cells[5].Value = dr[5].ToString();
                        if (dr[6].ToString() == "") metroGrid1.Rows[i].Cells[6].Value = "No Complain";
                        else metroGrid1.Rows[i].Cells[6].Value = dr[6].ToString();
                        metroGrid1.Rows[i].Cells[7].Value = dr[7].ToString();
                        i++;
                    }

                    dr.Close();
                }
                dread.Close();

            }
        }
    }
}
