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
    public partial class CeoAddWorker : Form
    {
        public CeoAddWorker()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select username from Employees where username ='" + LastnameBox.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count ==1 )
            {
                MessageBox.Show("The username allready exists in the system, select another user name", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand sda1 = new SqlCommand("INSERT INTO Employees (username,password,type) VALUES ('" + UsernameBox.Text + "','" + PasswordBox.Text + "','" + TypeBox.Text + "')",conn); 
                SqlCommand sda2= new SqlCommand("INSERT INTO Extend_Employees (First_Name, Last_Name, mobile, id, gender) VALUES ('" + FirstnameBox.Text + "','" + LastnameBox.Text + "','" + PhoneBox.Text + "','" + IDBox.Text + "','" + GenderBox.Text + "')", conn);
                //SqlCommand sda3 = new SqlCommand("INSERT INTO UserKey (UserId,UserName) VALUES ('" + UsernameBox.Text + "','" + IDBox.Text + "')", conn);

                SqlDataAdapter da = new SqlDataAdapter(sda1);
                SqlDataAdapter da1 = new SqlDataAdapter(sda2);
               // SqlDataAdapter da2 = new SqlDataAdapter(sda3);

                DataSet ds = new DataSet();
                da.Fill(ds);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
               // DataSet ds2 = new DataSet();
               // da1.Fill(ds2);
                MessageBox.Show("TUDO BOM", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CeoAddWorker_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
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
