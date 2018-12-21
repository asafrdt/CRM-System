using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team5_project
{
  
    public partial class Work_Hours : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Work_Hours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                string sql = "select Username,logdate ad 'Date', min(logtime) as 'IN',max(logtime) as 'OUT', " +
                    " CAST(((strftime('%s', max(logtime)  ) - strftime('%s',  min(logtime)  )) %(60*60*24))/(60*60) AS TEXT) || ':' || " +
                    " CAST(((strftime('%s', max(logtime)  ) - strftime('%s',  min(logtime)  )) %(60*60*24))%(60*60)) / 60 AS TEXT) as 'HOURS - HH:MM'   " +
                    "FROM Work_card group by Username,logdate order by logdate";
               
                sda = new SqlDataAdapter(sql, con);
                SqlCommand cmd = new SqlCommand(sql, con);
                dt = new DataTable(sql);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch
            {

            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
           
        }
    }
}
