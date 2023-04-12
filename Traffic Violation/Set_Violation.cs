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
    public partial class Set_Violation : UserControl
    {
        string connstr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int newid;
        public Set_Violation()
        {
            InitializeComponent();
        }

        private void Set_Violation_Load(object sender, EventArgs e)
        {
            int maxid;
            conn = new OracleConnection(connstr);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GetViolationID";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                maxid = Convert.ToInt32(c.Parameters["id"].Value.ToString());
                newid = maxid + 1;
            }
            catch
            {
                newid = 1;

            }
            txt_VID.Text = newid.ToString();
        }
        // ADD Button
        private void metroTile1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into VIOLATIONINFO (VIOLATIONID,CARID,VIOLATIONDES,VDATE,VTIME,VLOCATION) values (:violationid,:carid,:vdesc,:vdate,:vtime,:vlocation)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("violationid", txt_VID.Text);
            cmd.Parameters.Add("carid", txt_CID.Text);
            cmd.Parameters.Add("vdesc", txt_VDES.Text);
            cmd.Parameters.Add("vdate", txt_VD.Text);
            cmd.Parameters.Add("vtime", txt_VT.Text);
            cmd.Parameters.Add("vlocation", txt_VL.Text);


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("Done!");
        }
    }
}
