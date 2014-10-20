using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace unis
{
    partial class Dbconnect
    {

        public void Clocks(DataGridView dgv, ProgressBar bar, Button exe)
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

            saveFileDialog1.Filter = @"dat files (*.dat)|*.dat";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string savedirectoory = saveFileDialog1.FileName;


                var f = new FileStream(savedirectoory, FileMode.Create, FileAccess.ReadWrite);


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

                    SqlCommand update = new SqlCommand(sql, ShareConnection);

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
                exe.Enabled = true;
                bar.Style = ProgressBarStyle.Continuous;
                MessageBox.Show(@"Export complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
