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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.IO;

namespace Team5_project
{
    public partial class GeneralWorkHours : Form
    {
        public GeneralWorkHours()
        {
            InitializeComponent();
            Fillcombo();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Fillcombo()
        {
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Employees ", conn);
            comboBox1.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username from Employees";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["username"].ToString());
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != Login.UserID)
                {
                    MessageBox.Show("Please choose your name! ", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                    SqlDataAdapter sda = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(@"select Eid,Username, logdate, logtimeIn, logtimeOut,CalculateHours FROM Work_card WHERE Username='" + comboBox1.Text + "'", con);
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
