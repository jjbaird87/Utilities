using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace unis
{
    public partial class Dbconnect
    {
        public void loadDb_view(DataGridView dgv)
        {
            const string str = "SELECT c_name FROM dbo.tTerminal";
            var dataAdapter = new SqlDataAdapter(str,
                @"Data Source=JJ_LAPTOP\SQLEXPRESS;Initial Catalog=UNIS;Persist Security Info=True;User ID=jj;Password=evolution");
            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataTable();
            dataAdapter.Fill(ds);
            dgv.DataSource = ds;

            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Checked";
            checkColumn.HeaderText = "Checked";
            dgv.Columns.Add(checkColumn);

            string IN = "IN";
            string OUT = "OUT";
            var select = new DataGridViewComboBoxColumn();
            select.HeaderText = "Direction";
            select.Name = "Direction";
            select.Items.Add(IN);
            select.Items.Add(OUT);
      
            dgv.Columns.Add(select);
        }



        public void Load(DataGridView dgv)
        {
            try
            {
                dgv.Refresh();
                XmlReader xmlFile = XmlReader.Create(@"c:/older/DGVXML.xml", new XmlReaderSettings());
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(xmlFile);

                DataGridView grid = new DataGridView();

                var nameColumn = new DataGridViewTextBoxColumn();
                nameColumn.Name = "Device_Name";
                nameColumn.HeaderText = "Device Name";
                dgv.Columns.Add(nameColumn);
                

                var checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Checked";
                checkColumn.HeaderText = "Checked";
                dgv.Columns.Add(checkColumn);

                string IN = "IN";
                string OUT = "OUT";
                var select = new DataGridViewComboBoxColumn();
                select.HeaderText = "Direction";
                select.Name = "Direction";
                select.Items.Add(IN);
                select.Items.Add(OUT);
                dgv.Columns.Add(select);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string DeviceName = row[0].ToString();

                     bool Enabled = false;
                    if (row[1].ToString() != "")
                        Enabled = Convert.ToBoolean( row[1].ToString());

                    string Direction = row[2].ToString();

                    DataGridViewRow dgRow = new DataGridViewRow();
                    dgv.Rows.Add(new object[] {DeviceName, Enabled, Direction});
                }
             
                xmlFile.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
