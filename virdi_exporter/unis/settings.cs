using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace unis
{
    internal class Settings 
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
                    dataRow[i] = dr.Cells[i].Value;
                }
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
            {

                MessageBox.Show(@"Save attempt failed, please restart the program or load default settings and and try save again", @"Save failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        public void LoginSave(string username, string server, string password)
        {
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
                xdoc.Descendants().First().Add(xml);
            else
            {
                xdoc.Add(xml);
            }
            xdoc.Element("Login").Save("../Login.xml");
        }   
    }
}
