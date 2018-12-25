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
  
    public partial class Work_Hours : Form
    {
        DataTable dt;
        SqlCommandBuilder scb;
        SqlDataAdapter sda;
        public Work_Hours()
        {
            InitializeComponent();
            Fillcombo();

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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(@"select Username, logdate, logtimeIn, logtimeOut,CalculateHours FROM Work_card WHERE Username='" + comboBox1.Text + "'", con);
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                if(comboBox1.Text == "")
                {
                    MessageBox.Show("Please choose an employee ! ","alert", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Work_Hours_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(@"select Username, logdate, logtimeIn, logtimeOut,CalculateHours FROM Work_card" + "", con);
                sda.SelectCommand = cmd;
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlCommand cmd;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\STOREMANGE.MDF;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Work_card WHERE Username='" + comboBox1.Text + "'", conn);
                DataTable dbdataset2 = new DataTable();
                //sda.Fill(dbdataset2);
                BindingSource bSource2 = new BindingSource();

                bSource2.DataSource = dbdataset2;
                dataGridView2.DataSource = bSource2;
                sda.Update(dbdataset2);

                DataSet ds2 = new DataSet("New_DataSet");
                ds2.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                sda.Fill(dbdataset2);
                ds2.Tables.Add(dbdataset2);
                ExcelLibrary.DataSetHelper.CreateWorkbook("Work_Hours_Report.xls", ds2);
                MessageBox.Show("The file has succesfully been created!!!\nThe excel report had been created in folder:\n D:/Project/Team5/Team5/Team5 project/Team5 project/bin/Debug", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
