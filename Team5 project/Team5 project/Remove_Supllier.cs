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
    public partial class Remove_Supllier : Form
    {
        public Remove_Supllier()
        {
            InitializeComponent();
        }
        public void Delete_Supllier(SqlConnection conn, string id = null)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Suppllier where Suppllier_id='" + id + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }
        private void SubmitBox_Click(object sender, EventArgs e)
        {
            int parsedValue;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select Suppllier_id from Suppllier where Suppllier_id ='" + DeleteSerialNumberBox.Text + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (!int.TryParse(DeleteSerialNumberBox.Text, out parsedValue))
                MessageBox.Show("'ID' is a number only field! Enter a vaild id and try again! ");
            else if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("This ID does not exist in the system\nplease try again", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //conn.Open();
                //SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "delete from Suppllier where Suppllier_id='" + DeleteSerialNumberBox.Text + "'";
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //MessageBox.Show("Product has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Delete_Supllier(conn, DeleteSerialNumberBox.Text);
                MessageBox.Show("Supllier has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteSerialNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Supllier_Load(object sender, EventArgs e)
        {

        }
    }
}
