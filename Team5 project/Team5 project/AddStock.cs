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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Suppllier ", conn);
            comboBox1.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Suppllier_full_name from Suppllier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Suppllier_full_name"].ToString());
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select Product_id from Inventory where Product_id ='" + textBox1.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
             if (!int.TryParse(textBox1.Text, out parsedValue))
                MessageBox.Show("'Serial number' is a number only field! Enter a vaild Serial number and try again! ");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Serial number is already exists in the system\nChange the quantity on the Edit window." ,"alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
                    MessageBox.Show("Fill out the missing text box please!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (!int.TryParse(textBox3.Text, out parsedValue))
                    MessageBox.Show("'Quantity' is a number only field! Enter a vaild Quantity and try again! ");
                else if (!int.TryParse(textBox4.Text, out parsedValue))
                    MessageBox.Show("'Price' is a number only field! Enter a vaild Price and try again! ");
                
                else
                {
                    SqlCommand sda2 = new SqlCommand("INSERT INTO Inventory (Product_id,Product_name,Quantity,Price,Suppllier_full_name) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", conn);
                    SqlDataAdapter da = new SqlDataAdapter(sda2);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("New stock has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddStock_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
