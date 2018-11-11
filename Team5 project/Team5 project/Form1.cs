using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Team5_project
{
    public partial class Form1 : Form
    {
        public string utype;
        public Form1()
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

            
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project 2018\Team5\Team5 project\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
           sda.Fill(dt);

      

            if (dt.Rows[0][0].ToString() == "1")
            {
               
                if (utype =="A")
                {
                    this.Hide();
                    Admin mm = new Admin();
                    mm.Show();
                }
                else
                {
                    {
                        this.Hide();
                        Main mm = new Main();
                        mm.Show();
                    }
                }
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
    }
}
