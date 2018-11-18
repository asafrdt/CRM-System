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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Team5\Team5\Team5 project\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select ID from login where ID ='" + DeleteIDBox.Text + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("NO ID HAS BEEN FOUND", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from login where id='" + DeleteIDBox.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("USER HAS BEEN DELETED", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
//}
