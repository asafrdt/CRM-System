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
   
    public partial class Show_Edit_Customer : Form
    {

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Show_Edit_Customer()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter(@"select Costumer_id as 'Customer Id',Costumer_Full_name as 'Full name',Costumer_Mobile as 'Phone number' FROM Costumers", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter(@"select Costumer_id as 'Customer Id',Costumer_Full_name as 'Full name',Costumer_Mobile as 'Phone number' FROM Costumers", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void Show_Edit_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
