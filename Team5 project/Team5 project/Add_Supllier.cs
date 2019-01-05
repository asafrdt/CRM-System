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
    public partial class Add_Supllier : Form
    {
        public Add_Supllier()
        {
            InitializeComponent();
        }
        public void Add_Sup(SqlConnection conn, string Suppllier_id = null,  string Suppllier_full_name = null, string Employee_mobile = null)
        {

            SqlCommand sda2 = new SqlCommand("INSERT INTO Suppllier (Suppllier_id,Suppllier_full_name,Suppllier_mobile) VALUES ('" + Suppllier_id + "','" + Suppllier_full_name + "','" + Employee_mobile + "')", conn);
            SqlDataAdapter da = new SqlDataAdapter(sda2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select Suppllier_id from Suppllier where Suppllier_id ='" + textBox1.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("ID is already exists in the system!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //SqlCommand sda2 = new SqlCommand("INSERT INTO Suppllier (Suppllier_id,Suppllier_full_name,Suppllier_mobile) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
                //SqlDataAdapter da = new SqlDataAdapter(sda2);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //MessageBox.Show("New supplier had been added !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Add_Sup(conn, textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("New supplier had been added !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
