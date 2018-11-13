using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Team5_project
{
    public partial class Login : Form
    {
        public string utype;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


<<<<<<< HEAD
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Team5\Team5 project\Login.mdf;Integrated Security=True;Connect Timeout=30");
=======
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project 2018\Team5\Team5 project\Login.mdf;Integrated Security=True;Connect Timeout=30");
>>>>>>> 5b47b6794a943985ed720ef19bd32c329e7540bd
            SqlDataAdapter sda = new SqlDataAdapter("select type from login where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                utype = dt.Rows[0][0].ToString().Trim();
                if (utype == "A")
                {
                    this.Hide();
                    Ceo mm = new Ceo();
                    mm.Show();
                }
                else if (utype == "B")
                {
                    this.Hide();
                    Exp mm = new Exp();
                    mm.Show();
                }
                else if (utype == "C")
                {
                    this.Hide();
                    Cashier mm = new Cashier();
                    mm.Show();
                }
<<<<<<< HEAD
            }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======

>>>>>>> 5b47b6794a943985ed720ef19bd32c329e7540bd
            }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
