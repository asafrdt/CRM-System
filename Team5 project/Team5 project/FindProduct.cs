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
    public partial class FindProduct : Form
    {
        public static string Product;
        public static string Quantity;
        public int New_Q;

        public FindProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchbyid(ProductSearch.Text.Trim());
        }
        protected void searchbyid(string searchText)
        {
            if (ProductSearch.Text == "")
            {
                MessageBox.Show("No Id to search!");

            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
                {
                    string sql = "SELECT * FROM Inventory WHERE Serialnumber = '" + ProductSearch.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("Serialnumber", ProductSearch.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        if (dt.Rows.Count > 0)
                        { //check if the query returns any data
                            dataGridView1.DataSource = dt;
                            //dg1.DataBind();
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                }

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        //private void returnCashier_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    ExpStore ss = new ExpStore();
        //    ss.Show();
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            FindProduct.Product = ProductSearch.Text;
            FindProduct.Quantity = textBox1.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select Quantity from Inventory where Serialnumber ='" + ProductSearch.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string New_Q1 = dt.Rows[0]["Quantity"].ToString();
            int Q = Convert.ToInt32(New_Q1);
            int Q1 = Convert.ToInt32(FindProduct.Quantity);

            if (Q1 > Q)
                MessageBox.Show("There are not enough products in the store inventory","ERROR", MessageBoxButtons.RetryCancel);
            else
            {
                int NewQ = Q - Q1;
          
                this.Close();
                Checkout ss = new Checkout();
                ss.label6.Text = FindProduct.Product;
                ss.label3.Text = FindProduct.Quantity;
                ss.Show();
            }
        }

        private void ProductSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}