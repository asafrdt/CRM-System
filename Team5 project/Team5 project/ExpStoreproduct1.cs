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
    public partial class ExpStoreproduct1 : Form
    {
        public ExpStoreproduct1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Team5\Team5\Team5 project\DataBase\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
           SqlDataAdapter sda1 = new SqlDataAdapter("select productname from Inventory where serialnumber ='" + Serialnumbox.Text + "'", conn);
           DataTable dt2 = new DataTable();
           sda1.Fill(dt2);
           if (dt2.Rows.Count ==1)
            {
                MessageBox.Show("The product allready exists in the system, select another user name for ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand sda = new SqlCommand("INSERT INTO Inventory(Productname,product_description,Serialnumber,Quantity,Price) VALUES ('" + Productnamebox.Text + "','" + Productdescbox.Text + "','" + Serialnumbox.Text + "','" + quntitybox.Text + "','" + PriceBox + "')", conn);
                SqlDataAdapter da2 = new SqlDataAdapter(sda);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                DialogResult dialogResult = MessageBox.Show("האם תרצה להכניס מוצר נוסף?", "מה תרצה לעשות", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                    ExpStoreproduct1 ss = new ExpStoreproduct1();
                    ss.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                    ExpStore ss = new ExpStore();
                    ss.Show();
                }
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}