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
    public partial class CeoDeleteWorker : Form
    {
        public CeoDeleteWorker()
        {
            InitializeComponent();
        }



        private void SubmitBox_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
           // SqlDataAdapter sda2 = new SqlDataAdapter("select id from Extend_Employees where id ='" + DeleteIDBox.Text + "'", conn);
            SqlDataAdapter sda3 = new SqlDataAdapter("select username from Employees where Employee_id ='" + DeleteIDBox.Text + "'", conn2);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
           // DataTable dt2 = new DataTable();
           // sda2.Fill(dt2);
            if (dt3.Rows.Count == 0)
            {
                MessageBox.Show("NO ID HAS BEEN FOUND", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //conn.Open();
                //SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "delete from Extend_Employees where id='" + DeleteIDBox.Text + "'";
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //MessageBox.Show("Eployee ID has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn2.Open();
                SqlCommand cmd1 = conn2.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "delete from Employees where Employee_id='" + DeleteIDBox.Text + "'";
                cmd1.ExecuteNonQuery();
                conn2.Close();
                MessageBox.Show("Employee has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void DeleteIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1234_Click(object sender, EventArgs e)
        {

        }

        private void CeoDeleteWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
//}
