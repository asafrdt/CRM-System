using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team5_project;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace Team5_project.Tests
{
    [TestClass()]
    public class Team5UniTest
    {
        [TestMethod()]
        public void Add_customerTest()
        {
            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Costumers", conn);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            var result=false;
            NewCostumer newc = new NewCostumer();
            Remove_Customer c = new Remove_Customer();
            newc.Add_customer(conn, id);
            if (dt2.Rows != null) { result = true; }
            c.Delete_customer(conn, id);
            Assert.IsTrue(result);


        }
        [TestMethod()]
        public void Delete_customerTest()
        {
            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select Costumer_id from Costumers where Costumer_id ='" + id + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Remove_Customer c = new Remove_Customer();
            NewCostumer newc = new NewCostumer();
            newc.Add_customer(conn, id);
            c.Delete_customer(conn, id);
            Assert.AreEqual(dt2.Rows.Count, 0);

        }
        [TestMethod()]
        public void Add_WorkerTest()
        {
            string id = "1";
            string username = "Test";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Employees", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CeoAddWorker newc = new CeoAddWorker();
            CeoDeleteWorker c = new CeoDeleteWorker();
            var result = false;

            newc.Add_Worker(conn, username, id);
            if (dt2.Rows != null) { result = true; }

            c.Delete_Worker(conn, id);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void Delete_WorkerTest()
        {
            string username = "Test";
            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select username from Employees where Employee_id ='" + id + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CeoDeleteWorker c = new CeoDeleteWorker();
            CeoAddWorker newc = new CeoAddWorker();
            newc.Add_Worker(conn, username, id);
            c.Delete_Worker(conn, id);
            Assert.AreEqual(dt2.Rows.Count, 0);
        }

        [TestMethod()]
        public void Add_SupTest()
        {
            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Suppllier", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            var result = false;
            Add_Supllier newc = new Add_Supllier();
            Remove_Supllier c = new Remove_Supllier();
            newc.Add_Sup(conn, id);
            if (dt2.Rows != null) { result = true; }
            c.Delete_Supllier(conn, id);
            Assert.IsTrue(result);

        }

        [TestMethod()]
        public void Delete_SupllierTest()
        {

            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select Suppllier_id from Suppllier where Suppllier_id ='" + id + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Add_Supllier newc = new Add_Supllier();
            Remove_Supllier c = new Remove_Supllier();
            newc.Add_Sup(conn, id);
            c.Delete_Supllier(conn, id);
            Assert.AreEqual(dt2.Rows.Count, 0);
        }

        [TestMethod()]
        public void Change_pasTest()
        {
            string id = "1";
            string username = "Test";
            string pass = "123";
            string newpas = "111";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Employees", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);           
            CeoAddWorker newc = new CeoAddWorker();
            CeoDeleteWorker c = new CeoDeleteWorker();
            Change_password p = new Change_password();            
            newc.Add_Worker(conn, username, id,pass);
            p.Change_pas(conn, newpas, username);
            SqlDataAdapter sda = new SqlDataAdapter("select password from Employees where username ='" + username + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string New_Q1 = dt.Rows[0]["password"].ToString();
            int s = Convert.ToInt32(New_Q1);
            int s1 = Convert.ToInt32(newpas);
            bool result = s.Equals(s1);
            c.Delete_Worker(conn, id);
            Assert.IsTrue(result);
        }
    }
}