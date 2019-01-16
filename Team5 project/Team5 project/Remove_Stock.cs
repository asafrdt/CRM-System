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
    public partial class Remove_Stock : Form
    {
        public Remove_Stock()
        {
            InitializeComponent();
        }

        private void SubmitBox_Click(object sender, EventArgs e)
        {
            int parsedValue;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select Product_id from Inventory where Product_id ='" + DeleteSerialNumberBox.Text + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (!int.TryParse(DeleteSerialNumberBox.Text, out parsedValue))
                MessageBox.Show("'serial number' is a number only field! Enter a vaild serial number and try again! ");
            else if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("The serial number does not exist in the system\nplease try again", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Inventory where Product_id='" + DeleteSerialNumberBox.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1234_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSerialNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
