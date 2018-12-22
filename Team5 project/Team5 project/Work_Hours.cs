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
        DataTable dt;
        SqlCommandBuilder scb;
        SqlDataAdapter sda;
        public Work_Hours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                string sql = "SELECT Username  ,logdate as 'Date' , MIN(logtime) as 'IN' , MAX(logtime) as 'OUT', " +
                    " CAST(((strftime('%s', max(logtime)) - strftime('%s', min(logtime))) % (60 * 60 * 24)) / (60 * 60) AS TEXT) || ':' || " +
                    " CAST((((strftime('%s', max(logtime)) - strftime('%s', min(logtime))) % (60 * 60 * 24)) % (60 * 60)) / 60 AS TEXT) as 'HOURS - HH:MM'  " +
                    " FROM Work_card  group by Username , logdate order by logdate";
                //group by Username,logdate order by logdate"
                sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(sql, con);
                sda.SelectCommand = cmd;
                dt = new DataTable();
                BindingSource bsource = new BindingSource();
                sda.Fill(dt);
                bsource.DataSource = dt;
                dataGridView2.DataSource = dt;
                /*BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView2.DataSource = bsource;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                dt = new DataTable();
                //da.Fill(ds);
                sda = new SqlDataAdapter(sql, con);
                sda.Fill(dt);
                dataGridView2.DataSource = dt;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
           
        }
    }
}
