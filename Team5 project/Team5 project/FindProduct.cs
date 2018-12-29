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
        public static string Product_name;
        public static string Product_price;
        public static int int_Product_price;
        public static int int_Update_quaintity;

        public static string Quantity;
        public int New_Q;

        public FindProduct()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Inventory ", conn);
            comboBox1.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Serialnumber from Inventory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Serialnumber"].ToString());
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchbyid(comboBox1.Text.Trim());
        }
        protected void searchbyid(string searchText)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No Id to search!");

            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\StoreMange.mdf;Integrated Security=True;Connect Timeout=30");
                {
                    string sql = "SELECT * FROM Inventory WHERE Serialnumber = '" + comboBox1.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("Serialnumber", comboBox1.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        if (dt.Rows.Count > 0)
                        { //check if the query returns any data
                            FindProduct.Product = comboBox1.Text;
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
            if (textBox1.Text == "")
                MessageBox.Show("Something get wrong, fill the quantity number and try again!", "ERROR", MessageBoxButtons.OK);
            else
            {
                if (FindProduct.Product == comboBox1.Text && FindProduct.Product != "" && comboBox1.Text != "") {
                   FindProduct.Quantity = textBox1.Text;
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                    SqlDataAdapter sda3 = new SqlDataAdapter("select Product_name from Inventory where Serialnumber ='" + comboBox1.Text + "'", conn);
                    DataTable dt2 = new DataTable();
                    sda3.Fill(dt2);
                    SqlDataAdapter sda = new SqlDataAdapter("select Quantity from Inventory where Serialnumber ='" + comboBox1.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    SqlDataAdapter sda2 = new SqlDataAdapter("select Price from Inventory where Serialnumber ='" + comboBox1.Text + "'", conn);
                    DataTable dt3 = new DataTable();
                    sda2.Fill(dt3);
                    FindProduct.Product_name = dt2.Rows[0]["Product_name"].ToString();
                    FindProduct.Product_price = dt3.Rows[0]["Price"].ToString();
                    string New_Q1 = dt.Rows[0]["Quantity"].ToString();
                    int Q = Convert.ToInt32(New_Q1);
                    int Q1 = Convert.ToInt32(FindProduct.Quantity);
                    int P = Convert.ToInt32(FindProduct.Product_price);
                    int Total_price = Q1 * P;
                    FindProduct.int_Product_price = Total_price;
                    if (Q1 > Q)
                        MessageBox.Show("There are not enough products in the store inventory", "ERROR", MessageBoxButtons.RetryCancel);
                    else
                    {
                        int NewQ = Q - Q1;
                        FindProduct.int_Update_quaintity = NewQ;
                        this.Close();
                        Checkout ss = new Checkout();
                        ss.label4.Text = ExitingCoustumer.Customer;
                        ss.label6.Text = FindProduct.Product;
                        ss.label3.Text = FindProduct.Quantity;
                        ss.label11.Text = FindProduct.Product_name;
                        ss.label9.Text = Total_price.ToString();
                        ss.Show();
                    }
                }
                else
                {
                    MessageBox.Show("first you need to find a product, than try again!", "ERROR", MessageBoxButtons.RetryCancel);

                }
            }
        }

        private void ProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindProduct_Load(object sender, EventArgs e)
        {

        }
    }
}