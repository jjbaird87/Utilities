using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using unis.Properties;

namespace unis
{
    public partial class Form1 : Form
    {
        private Dbconnect cNet = new Dbconnect();
        private CreateClocks clk = new CreateClocks();
        private Settings seting = new Settings();


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cNet.Dbconnection(txtPassword.Text, txtDbname.Text, TXTServNameIP.Text, txtUserName.Text, textBox1.Text,
                txtField.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clk.clocks(DataView);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cNet.loadDb_view(DataView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

            
        private void btnSave_Click(object sender, EventArgs e)
        {
            seting.Save(DataView);

           //DataTable dT = seting.saveDGV(DataView);
           //DataSet dS = new DataSet();
           //dS.Tables.Add(dT);
           //dS.WriteXml(File.OpenWrite(@"c:/older/hnewXML.xml"),XmlWriteMode.WriteSchema);
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cNet.Load(DataView);
        }



        private void button3_Click_2(object sender, EventArgs e)
        {
          DataView.Columns.Clear();
           cNet.Load(DataView);
        }
    }
}
