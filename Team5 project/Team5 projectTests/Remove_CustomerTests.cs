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
    public class Remove_CustomerTests
    {
        [TestMethod()]
        public void Add_customerTest()
        {
            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Costumers " , conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            NewCostumer newc = new NewCostumer();
            Remove_Customer c = new Remove_Customer();

            newc.Add_customer(conn, id);
            c.Delete_customer(conn, id);
            Assert.AreEqual(dt2.Rows.Count, 1);
            
        }
        [TestMethod()]
        public void Delete_customerTest()
        {
            string id = "1";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\TEAM5\TEAM5\TEAM5 PROJECT\DATABASE\UniTestData.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("select Id from Costumers where Id ='" + id + "'", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Remove_Customer c = new Remove_Customer();
            NewCostumer newc = new NewCostumer();
            newc.Add_customer(conn, id);
            c.Delete_customer(conn, id);
          Assert.AreEqual(dt2.Rows.Count, 0);
           
        }

 
    }
}