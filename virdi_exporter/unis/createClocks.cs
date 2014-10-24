using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace unis
{
    partial class Dbconnect
    {
      
        private string _savedirectoory = "";
        private string RunEXEfile = "";


        public void RunFile(CheckBox exe)
        {
            if (exe.Checked == true)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = RunEXEfile;
                proc.StartInfo.UseShellExecute = true;
                try
                {
                    proc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }


        public void fileSave(string check,TextBox nameFile)
        {
            XDocument xdoc = new XDocument(new XElement("File"));

            xdoc = new XDocument();
            XElement xmlstart = new XElement("File");
            xdoc.Add(xmlstart);

            XElement xml =
                           new XElement("FilePath",
              new XElement("FileName", nameFile.Text),
              new XElement("Checked", check)
             );

            if (xdoc.Descendants().Count() > 0)
                xdoc.Descendants().First().Add(xml);
            else
            {
                xdoc.Add(xml);
            }
            xdoc.Element("File").Save(@"C:\Users\Public\VIRDI CLOCKING\ExeFile.xml");
        }

        public void browser(TextBox file)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = @"All |*";
            openFile.ShowDialog();
            RunEXEfile = openFile.FileName;
            file.Text = RunEXEfile;
        }

        public void TimedClocks(DataGridView dgv, ProgressBar bar, Button exe, Timer tym,Timer tymupdate,string state,CheckBox fileRun)
        {       
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            exe.Enabled = false;
            if (ShareConnection.State == ConnectionState.Closed)
            {
                try
                {
                    ShareConnection.Open();
                }
                catch (Exception)
                {
                    exe.Enabled = true;
                    return;
                }
            }

            saveFileDialog1.RestoreDirectory = true;
         
           
            var f = new FileStream(_savedirectoory, FileMode.Append, FileAccess.Write);

            var w = new StreamWriter(f);

            var datInfo = new DataTable();
            var sqlString =
                string.Format(
                    "SELECT tEnter.C_Date,tEnter.Exported, tEnter" +
                    ".C_Time, tEnter.C_Unique, tTerminal.C_Name, tEnter.L_TID FROM " +
                    " tEnter INNER JOIN tTerminal ON tEnter.L_TID = tTerminal.L_ID where" +
                    " tEnter.Exported is null");

            var dbAdapater = new SqlDataAdapter(sqlString, ShareConnection);
            dbAdapater.Fill(datInfo);

            DataSet dataSet = new DataSet();

            XmlReader xmlFile = XmlReader.Create(@"C:\Users\Public\VIRDI CLOCKING\DGVXML.xml", new XmlReaderSettings());

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
                MessageBox.Show(
                    @"Exporting to .dat file has failed, please restart the program and set up new export settings",
                    @"Export failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xmlFile.Close();
                exe.Enabled = true;
                return;
            }

            //ShareConnection.Open();
            //SqlCommand comm = new SqlCommand("select count(c_name) from tEnter where Exported is null",
            //    ShareConnection);
            //Int32 count = (Int32) comm.ExecuteScalar();
            //ShareConnection.Close();

            foreach (DataRow row in datInfo.Rows)
            {
              
                bar.Style = ProgressBarStyle.Marquee;
                Application.DoEvents();

                if (ShareConnection.State == ConnectionState.Closed)
                {
                    Application.Exit();
                    return;
                }

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

                if (unique == "")
                {
                    continue;
                }
                string sql = "UPDATE tEnter SET Exported = 1 WHERE C_Time = " + checktime + " and C_Date = " +
                             checkDate + " and C_Unique = '" + unique +"'";


                var update = new SqlCommand(sql, ShareConnection);

                try
                {
                    if (ShareConnection.State == ConnectionState.Closed)
                    {
                        throw new Exception("connection is closed");
                    }
                    update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);       
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
            tym.Start();
            try
            {
                w.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            tym.Start();
            tymupdate.Start();
            xmlFile.Close();
            exe.Enabled = true;
            bar.Style = ProgressBarStyle.Continuous;
            RunFile(fileRun);
        }


        public void Clocks(DataGridView dgv, ProgressBar bar, Button exe, Timer tym, Timer tymUpdate,string state,CheckBox ChkEXE)
        {
            tym.Stop();
            tymUpdate.Stop();
            var saveFileDialog1 = new SaveFileDialog();

            exe.Enabled = false;
            if (ShareConnection.State == ConnectionState.Closed)
            {
                try
                {
                    ShareConnection.Open();
                }
                catch (Exception)
                {
                    exe.Enabled = true;
                    return;
                }
            }

            saveFileDialog1.Filter = @"dat files (*.dat)|*.dat";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Clocks";
        
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _savedirectoory = saveFileDialog1.FileName;
             
                //C:\Users\Karabo\Desktop\HF.dat

                var f = new FileStream(_savedirectoory, FileMode.Create, FileAccess.ReadWrite);

                var w = new StreamWriter(f);

                var datInfo = new DataTable();
                var sqlString =
                    string.Format(
                        "SELECT tEnter.C_Date,tEnter.Exported, tEnter" +
                        ".C_Time, tEnter.C_Unique, tTerminal.C_Name, tEnter.L_TID FROM " +
                        " tEnter INNER JOIN tTerminal ON tEnter.L_TID = tTerminal.L_ID where" +
                        " tEnter.Exported is null");

                var dbAdapater = new SqlDataAdapter(sqlString, ShareConnection);
                dbAdapater.Fill(datInfo);

                DataSet dataSet = new DataSet();

                XmlReader xmlFile = XmlReader.Create(@"C:\Users\Public\VIRDI CLOCKING\DGVXML.xml", new XmlReaderSettings());

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
                    MessageBox.Show(
                        @"Exporting to .dat file has failed, please restart the program and set up new export settings",
                        @"Export failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    xmlFile.Close();
                    exe.Enabled = true;
                    return;
                }

                foreach (DataRow row in datInfo.Rows)
                {
                    tym.Stop();
                    bar.Style = ProgressBarStyle.Marquee;
                    Application.DoEvents();

                    if (ShareConnection.State == ConnectionState.Closed)
                    {                 
                        Application.Exit();
                        return;
                    }

                    if (list.Find(i => i == row["C_Name"].ToString()) == null)
                    {
                        continue;
                    }
                 
                    string checktime = row["C_Time"].ToString();
                    string checkDate = row["C_Date"].ToString();
                    string unique = row["C_Unique"].ToString();

                    if (unique == "")
                    {
                        continue;
                    }
                    string sql = "UPDATE tEnter SET Exported = 1 WHERE C_Time = " + checktime + " and C_Date = " +
                                 checkDate + " and C_Unique = '"+ unique +"'";


                    var update = new SqlCommand(sql, ShareConnection);

                    try
                    {
                        if (ShareConnection.State == ConnectionState.Closed)
                        {
                            throw new Exception("connection is closed");
                        }
                        update.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

                tym.Start();
                tymUpdate.Start();
                w.Dispose();         
                xmlFile.Close();
                exe.Enabled = true;
                bar.Style = ProgressBarStyle.Continuous;
                MessageBox.Show(@"Export complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }
        }
    }
}
