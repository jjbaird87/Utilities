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
            var dataAdapter = new SqlDataAdapter(str, ShareConnection);
            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataTable();
            dataAdapter.Fill(ds);
            dgv.DataSource = ds;

            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Select";
            checkColumn.HeaderText = @"Select";
            dgv.Columns.Add(checkColumn);

            string IN = "IN";
            string OUT = "OUT";
            var select = new DataGridViewComboBoxColumn();
            select.HeaderText = @"Direction";
            select.Name = "Direction";
            select.Items.Add(IN);
            select.Items.Add(OUT);
      
            dgv.Columns.Add(select);

            dgv.Columns[0].HeaderCell.Value = "Device Name";
        }


        public void LoadLogin(TextBox server, TextBox user, TextBox pass)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\Public\VIRDI CLOCKING\Login.xml");
                XmlNode node = doc.SelectSingleNode("/Login/Login/ServerId");
                server.Text = node.InnerText;

                XmlNode node2 = doc.SelectSingleNode("/Login/Login/UserId");
                user.Text = node2.InnerText;

                XmlNode node3 = doc.SelectSingleNode("/Login/Login/Password");
                pass.Text = node3.InnerText;
            }
            catch (Exception)
            {
                MessageBox.Show(@"First run of the program, login details will be saved apon successful login", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }


        public void Load(DataGridView dgv)
        {
            dgv.DataSource = null;
            try
            {
                dgv.Refresh();
                XmlReader xmlFile = XmlReader.Create(@"C:\Users\Public\VIRDI CLOCKING\DGVXML.xml", new XmlReaderSettings());
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(xmlFile);


                var nameColumn = new DataGridViewTextBoxColumn();
                nameColumn.Name = "Device Name";
                nameColumn.HeaderText = @"Device Name";
                dgv.Columns.Add(nameColumn);
                dgv.Columns["Device Name"].ReadOnly = true;
                

                var checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Select";
                checkColumn.HeaderText = @"Select";
                dgv.Columns.Add(checkColumn);

                string IN = "IN";
                string OUT = "OUT";
                var select = new DataGridViewComboBoxColumn();
                select.HeaderText = @"Direction";
                select.Name = "Direction";
                select.Items.Add(IN);
                select.Items.Add(OUT);
                dgv.Columns.Add(select);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string deviceName = row[0].ToString();

                     bool enabled = false;
                    if (row[1].ToString() != "")
                        enabled = Convert.ToBoolean( row[1].ToString());

                    string direction = row[2].ToString();

                    //DataGridViewRow dgRow = new DataGridViewRow();
                    dgv.Rows.Add(new object[] {deviceName, enabled, direction});
                }
                xmlFile.Close();
            }
            catch (Exception )
            {
                MessageBox.Show(@"Export settings have not been saved yet", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

    }
}
