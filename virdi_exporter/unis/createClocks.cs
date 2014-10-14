﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace unis
{
   partial class  Dbconnect
       {
        
        public void clocks(DataGridView dgv)
        {        
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "dat files (*.dat)|*.dat";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Savedirectoory = saveFileDialog1.FileName;
                var f = new FileStream(Savedirectoory, FileMode.Create, FileAccess.ReadWrite);
            
                var datInfo = new DataTable();
                var sqlString = string.Format("SELECT tEnter.C_Date, tEnter.C_Time, tEnter.C_Unique, tTerminal.C_Name, tEnter.L_TID FROM  tEnter INNER JOIN tTerminal ON tEnter.L_TID = tTerminal.L_ID");
                var dbAdapater = new SqlDataAdapter(sqlString,ShareConnection );
                dbAdapater.Fill(datInfo);
                var w = new StreamWriter(f);



                DataSet dataSet = new DataSet();
                XmlReader xmlFile = XmlReader.Create(@"/DGVXML.xml", new XmlReaderSettings());


                var list = new List<string>();
                var list2 = new List<string>();
                var check = new Dictionary<string, string>();
               

                dataSet.ReadXml(xmlFile);
                foreach (DataRow rows in dataSet.Tables[0].Rows)
                {
                    string cell1 = rows[0].ToString();
                    string cell2 = rows[1].ToString();
                    string cell3 = rows[2].ToString();

                    if (cell2 == "True")
                    {
                        list.Add(cell1);  
                        check.Add(cell1,cell3);               
                    }
                              
                }


                foreach (DataRow row in datInfo.Rows)
                {
                    if (list.Find(i => i == row["C_Name"].ToString()) == null)
                        continue;

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
                 

                    var datafileRow = String.Format("{0} {1} {2} {3} {4}", employee, dt1.ToString("d"),
                        dtTime.ToString("t"), direction, clock);
                    w.WriteLine(datafileRow);
                }
                w.Close();
            }


           
  
          
        }
       }
}
