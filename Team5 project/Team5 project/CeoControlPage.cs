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
    public partial class CeoControlPage : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
       // private int username;

        public CeoControlPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            // sda = new SqlDataAdapter(@"select username,password,type FROM Employees", con);
            sda = new SqlDataAdapter(@"select Id,First_Name,Last_Name,mobile,Gender FROM Extend_Employees", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void CeoControlPage_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string selected_username = dataGridView1.CurrentRow.Cells[username].Value.ToString();
            //string selected_password = dataGridView1.CurrentRow.Cells[password].Value.ToString();
            //string selected_type = dataGridView1.CurrentRow.Cells[type].Value.ToString();
            //string selected_firstname = dataGridView1.CurrentRow.Cells[].Value.ToString();
            //string selected_lastname = dataGridView1.CurrentRow.Cells[].Value.ToString();
            //string selected_phone = dataGridView1.CurrentRow.Cells[].Value.ToString();
            //string selected_id = dataGridView1.CurrentRow.Cells[].Value.ToString();
            //string selected_gender = dataGridView1.CurrentRow.Cells[].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void returnCashier_Click(object sender, EventArgs e)
        {
            this.Close();
            Checkout ss = new Checkout();
            ss.Show();
        }
    }
}
