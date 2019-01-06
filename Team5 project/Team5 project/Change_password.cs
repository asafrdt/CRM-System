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
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();
        }
        public void Change_pas(SqlConnection con,string pass,string id)
        {

            SqlCommand sda1 = new SqlCommand(" update Employees set password = '" + pass + " ' where username ='" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sda1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);


        }
        private void SubmitBox_Click(object sender, EventArgs e)
        {

            if (UpdatePassword1.Text == "" || UpdatePassword2.Text == "" || UpdatePassword1.Text.Trim() != UpdatePassword2.Text.Trim())
            {
                if (UpdatePassword1.Text == "")
                    MessageBox.Show("New password is required!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (UpdatePassword2.Text == "")
                    MessageBox.Show("New password is required!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (UpdatePassword1.Text.Trim() != UpdatePassword2.Text.Trim())
                    MessageBox.Show("The password you've enter doesn't match\n Please try again!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                    Change_pas(con, UpdatePassword2.Text, Login.UserID);
                    MessageBox.Show("Password has been changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_password_Load(object sender, EventArgs e)
        {

        }
    }
}
