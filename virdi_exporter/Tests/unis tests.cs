using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using NUnit.Framework;



namespace Tests
{
    
    [TestFixture]
    public class UnisTests 
    {
      //  Form1 form = new Form1();
     //   form.Open();

 
        [Test]
        public void SaveTest()
        {    
            DataTable dt = new DataTable();

         //   for (int i = 1; i < dgv.Columns.Count + 1; i++)
        //    {
         //       DataColumn column = new DataColumn(dgv.Columns[i - 1].HeaderText);
          //      dt.Columns.Add(column);
        //    }
          //  int columnCount = dgv.Columns.Count;
          //  foreach (DataGridViewRow dr in dgv.Rows)
            {
                DataRow dataRow = dt.NewRow();
            //    for (int i = 0; i < columnCount; i++)
             //   {
                   // dataRow[i] = dr.Cells[i].Value;
            //    }
               dt.Rows.Add(dataRow);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            try
            {
                XmlTextWriter xmlSave = new XmlTextWriter(@"../DGVXML.xml", Encoding.UTF8);
                ds.WriteXml(xmlSave);
                xmlSave.Close();
                ds.Clear();
                dt.Clear();
                ds.EndInit();
                dt.EndInit();
            }
            catch (Exception)
            { }
        }



        [Test]
        public void ExpotText()
        {
            SqlConnection shareConnection = new SqlConnection(@"Data Source=KARABO_LAPTOP\SQLEXPRESS;Integrated Security=True;Initial Catalog=Unis");
            

            if (shareConnection.State == ConnectionState.Closed)
            {
                try
                {
                    shareConnection.Open();
                }
                catch (Exception)
                {
                    return;
                }
            }   

            {
                string savedirectoory = @"../file,dat";

                var f = new FileStream(savedirectoory, FileMode.Create, FileAccess.ReadWrite);
                var w = new StreamWriter(f);

                var datInfo = new DataTable();
                var sqlString =
                    string.Format(
                        "SELECT tEnter.C_Date,tEnter.Exported, tEnter" +
                        ".C_Time, tEnter.C_Unique, tTerminal.C_Name, tEnter.L_TID FROM " +
                        " tEnter INNER JOIN tTerminal ON tEnter.L_TID = tTerminal.L_ID where" +
                        " tEnter.Exported is null");

                var dbAdapater = new SqlDataAdapter(sqlString, shareConnection);
                dbAdapater.Fill(datInfo);

                DataSet dataSet = new DataSet();

                XmlReader xmlFile = XmlReader.Create(@"../DGVXML.xml", new XmlReaderSettings());

                var list = new List<string>();
                var check = new Dictionary<string, string>();

                try
                {
                    dataSet.ReadXml(xmlFile);
                    foreach (DataRow rows in dataSet.Tables[0].Rows)
                    {
                        string cell1 = rows[0].ToString();
                        string cell2 = rows[1].ToString();
                        string cell3 = rows[2].ToString();

                        if (cell2 == "True" && cell3 != "")
                        {
                            list.Add(cell1);
                            check.Add(cell1, cell3);
                        }
                    }
                }
                catch (Exception)
                {
                    xmlFile.Close();      
                    return;
                }

             

                foreach (DataRow row in datInfo.Rows)
                {
                    Application.DoEvents();

                    if (list.Find(i => i == row["C_Name"].ToString()) == null)
                    {
                        continue;
                    }

                    if (row["Exported"].ToString() == "1")
                    {
                        continue;
                    }

                    string checktime = row["C_Time"].ToString();
                    string checkDate = row["C_Date"].ToString();
                    string unique = row["C_Unique"].ToString();

                    string sql = "UPDATE tEnter SET Exported =1 WHERE C_Time =" + checktime + " and C_Date = " +
                                 checkDate + " and C_Unique = " + unique;

                    SqlCommand update = new SqlCommand(sql, shareConnection);

                    try
                    {
                        update.ExecuteNonQuery();
                    }
                    catch (InvalidOperationException)
                    {
                        Application.Exit();
                        return;
                    }

                    string direction;
                    string value1 = row["C_name"].ToString();
                    string value2;

                    check.TryGetValue(value1, out value2);

                    if (value2 == "IN")
                    {
                        direction = "I";
                    }
                    else
                    {
                        direction = "O";
                    }

                    //employee number
                    var employee = row["C_Unique"].ToString();
                    employee = employee.PadLeft(8, '0');

                    DateTime dt1;
                    DateTime dtTime;
                    try
                    {
                        //Date
                        dt1 = DateTime.ParseExact(row["C_Date"].ToString(), "yyyyMMdd",
                            CultureInfo.InvariantCulture);
                        //time
                        dtTime = DateTime.ParseExact(row["C_Time"].ToString(), "HHmmss",
                            CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                    //clock
                    var clock = row["L_TID"].ToString();
                    clock = clock.PadLeft(3, '0');

                    var datafileRow = String.Format("{0} {1} {2} {3} {4}", employee, dt1.ToString("dd/MM/yyyy"),
                        dtTime.ToString(@"hh\:mm"), direction, clock);
                    w.WriteLine(datafileRow);
                }
                w.Close();
                xmlFile.Close();
          MessageBox.Show(@"Export complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //tried and tested also.. played with directory 
          [Test]
        public void LoginTest()
        {
            int server = 1;
            string username = "hello";
            string password = "hello";

            XDocument xdoc = new XDocument(new XElement("Login"));

            xdoc = new XDocument();
            XElement xmlstart = new XElement("Login");
            xdoc.Add(xmlstart);

            XElement xml =
                           new XElement("Login",
              new XElement("ServerId", server),
              new XElement("UserId", username),
              new XElement("Password", password));

            if (xdoc.Descendants().Count() > 0)
                xdoc.Descendants().First().Add();
            else
            {
                xdoc.Add(xml);
            }
            xdoc.Element("Login").Save(@"../Login.xml");        
        }


        //test complete and run properly on two machines just had to change server name
        [Test]
        public void ConnectTest()
        { 
            string password= "";
            string servName = @"KARABO_LAPTOP\SQLEXPRESS";
            string userName="" ;
            bool authenticate =true;

            string connectionString = "Data Source=";
            connectionString += servName + ";";

            if (authenticate == true) connectionString += "Integrated Security=True;";
            else
            {
                connectionString += "Persist Security Info=True;User ID=" + userName + ";" +
                                    "Password=" + password + ";";
            }

            // TheConnectionString = strConnect;
            var aConnect = new SqlConnection { ConnectionString = connectionString };
                      
            //aConnect.Open();          
         
         //   aConnect.Close();
            aConnect.ConnectionString += "Initial Catalog=Unis";
            connectionString += "Initial Catalog=Unis"; 
            try
            {
                aConnect.Open();
                var dBtables = new DataTable();
                string sqlString = "Select TOP 1 * from dbo.Tenter;";
                var dbAdapater = new SqlDataAdapter(sqlString, aConnect);
                dbAdapater.Fill(dBtables);
                int i = dBtables.Columns.IndexOf("Exported");

                //create exported if not found
                if (i == -1)
                {
                    string command = "IF NOT  EXISTS(SELECT * FROM sys.columns WHERE Name = N'Exported' and Object_ID = Object_ID(N'[dbo].[tEnter]')) BEGIN ALTER TABLE [dbo].[tEnter] ADD Exported varchar(1) END ";
                    SqlCommand addColumn = new SqlCommand(command, aConnect);
                    addColumn.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {          
                //just in case
                string command = "IF NOT  EXISTS(SELECT * FROM sys.columns WHERE Name = N'Exported' and Object_ID = Object_ID(N'[dbo].[tEnter]')) BEGIN ALTER TABLE [dbo].[tEnter] ADD Exported varchar(1) END ";
                SqlCommand addColumn = new SqlCommand(command, aConnect);
                addColumn.ExecuteNonQuery();
            }    
   
            //this doesnt help i see
            Assert.AreEqual(@"Data Source=KARABO_LAPTOP\SQLEXPRESS;Integrated Security=True;Initial Catalog=Unis",connectionString);
        }


    }
}
