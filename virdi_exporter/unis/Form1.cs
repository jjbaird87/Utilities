using System;
using System.Windows.Forms;

namespace unis
{
    public partial class Form1 : Form
    {
        private Dbconnect cNet = new Dbconnect();
        private Settings seting = new Settings();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool authent =false;
            try
            {

                if (TXTServNameIP.Text == "")
                {
                    return;
                }

                if (CheckBoxW_authenticate.Checked) authent = true;
                cNet.Dbconnection(txtPassword.Text, TXTServNameIP.Text, txtUserName.Text, authent);
                btnSave.Enabled = true;
                btnViewDefault.Enabled = true;
                btnExport.Enabled = true;
                btnViewDefault.Enabled = true;
                BtnLoadSettings.Enabled = true;
                DataView.Enabled = true;
                seting.LoginSave(txtUserName.Text,TXTServNameIP.Text,txtPassword.Text);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
           btnSave_Click(sender,e);
            cNet.clocks(DataView);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DataView.Columns.Clear();
            cNet.loadDb_view(DataView);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnViewDefault.Enabled = false;
            btnExport.Enabled = false;
            btnViewDefault.Enabled = false;
            BtnLoadSettings.Enabled = false;
            DataView.Enabled = false;
            button3_Click_2(sender, e);
            
            cNet.loadLogin(TXTServNameIP,txtUserName,txtPassword);
            
        }

            
        private void btnSave_Click(object sender, EventArgs e)
        {
            seting.Save(DataView);
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

        private void CheckBoxW_authenticate_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxW_authenticate.Checked == true)
            {
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
