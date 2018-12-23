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

 
       
                sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(@"select Username, logdate, logtimeIn, logtimeOut,CalculateHours FROM Work_card", con);
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

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

        private void Work_Hours_Load(object sender, EventArgs e)
        {

        }
    }
}
