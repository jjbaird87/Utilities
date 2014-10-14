using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace unis
{
    internal class Settings : ApplicationSettingsBase
    {

        public void Save(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                DataColumn column = new DataColumn(dgv.Columns[i - 1].HeaderText);
                dt.Columns.Add(column);
            }
            int columnCount = dgv.Columns.Count;
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                DataRow dataRow = dt.NewRow();
                for (int i = 0; i < columnCount; i++)
                {
                   //returns checkboxes and dropdowns as string with .value..... nearly got it
                    dataRow[i] = dr.Cells[i].Value;
                }
                dt.Rows.Add(dataRow);
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            XmlTextWriter xmlSave = new XmlTextWriter(@"c:/older/DGVXML.xml", Encoding.UTF8);
           
            ds.WriteXml(xmlSave);
            xmlSave.Close();
        }


       
        public void SaveJj(DataGridView dgv)
        {
            var dictionary = new ListDictionary();
            var stringList = new string[3];
            var i = 0;


            foreach (DataGridViewRow row in dgv.Rows)
            {
                stringList[0] += row.Cells["c_name"].Value;
                stringList[1] += row.Cells["ENABLED"].Value;
                stringList[2] += row.Cells["DIRECTION"].Value;

                dictionary.Add(String.Format("Row{0}", i), stringList);
                i++;
            }

            unis.Properties.Settings.Default.DeviceSettings = dictionary;
            unis.Properties.Settings.Default.Save();
        }
    }
}
