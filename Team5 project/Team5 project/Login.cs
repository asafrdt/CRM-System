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
        public static DateTime date1;
        public static TimeSpan timeOut;
        public static string date;
        public static TimeSpan timeIn;
        public static string UserID;
        public static DateTime timeLogin;
        public static DateTime timeLogout;

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

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select type from Employees where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count>0)
            {
                Login.UserID = textBox1.Text;
                timeLogin = DateTime.Now;
                String format = "yyyy-MM-dd HH:mm:ss";
                Login.date1 = DateTime.Now;
                for (int i = 0; i < 10; i++)
                    Login.date += timeLogin.ToString(format)[i];
                Login.timeIn = timeLogin.TimeOfDay;
                utype = dt.Rows[0][0].ToString().Trim();
                if (utype == "Ceo")
                { Ceo mm = new Ceo();
                    mm.label2.Text = UserID;
                    mm.label3.Text = utype;
                    this.Hide();
                    mm.Show();
                }
                else if (utype == "Expert")
                {
                    this.Hide();
                    Expert mm = new Expert();
                    mm.label2.Text = UserID;
                    mm.label3.Text = utype;
                    this.Hide();
                    mm.Show();
                }
                else if (utype == "Cashier")
                {
                    this.Hide();
                    Cashier mm = new Cashier();
                    mm.label2.Text = UserID;
                    mm.label3.Text = utype;
                    this.Hide();
                    mm.Show();
                }

            }
            else
            {
                MessageBox.Show("Please enter correct Username and Password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
