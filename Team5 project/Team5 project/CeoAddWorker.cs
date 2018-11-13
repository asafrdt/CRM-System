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
    public partial class CeoAddWorker : Form
    {
        public CeoAddWorker()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project\Team5\Team5 project\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select username from login where username ='" + textBox1.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The username allready exists in the system, select another user name", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand sda1 = new SqlCommand("INSERT INTO login(username,password,type) VALUES ('" + textBox1.Text +"','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
                 SqlDataAdapter da = new SqlDataAdapter(sda1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("TUDO BOM", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CeoAddWorker_Load(object sender, EventArgs e)
        {
            
        }
    }
}
