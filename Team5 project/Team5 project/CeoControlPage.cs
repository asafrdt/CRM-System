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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Team5\Team5\Team5 project\DataBase\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter(@"select username,password,type FROM Employees", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
