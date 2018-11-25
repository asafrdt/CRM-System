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
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Team5\Team5 project\DataBase\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void returnCashier_Click(object sender, EventArgs e)
        {
            this.Close();
            ExpStore ss = new ExpStore();
            ss.Show();
        }
    }
}