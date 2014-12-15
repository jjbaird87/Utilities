using System;
using System.Windows.Forms;

namespace VIRDI_CLOCKING_COLLECTOR 
{
    public partial class Form1 : Form
    {
        private Dbconnect cNet = new Dbconnect();
        private Settings seting = new Settings();
        private ToolSettings tools = new ToolSettings();
     
        DateTime timeSet = new DateTime(2014,01,01,0,5,0);

        public Form1()
        {
            InitializeComponent();
        }

   


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Click(sender, e);
            }
            catch (Exception)
            {             
                return;
            }
            cNet.Clocks(DataView, progressBar1, btnExport, timer1, timer2,ChkEXE.CheckState.ToString(),ChkEXE,timeSet);
            Application.DoEvents();          
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DataView.Columns.Clear();
            cNet.loadDb_view(DataView);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
       
            cNet.fileNmeLoader(txtFileName,ChkEXE);
            tools.path();
            button3_Click_2(sender, e);
            tools.FormLoader(btnSave,btnViewDefault,btnExport,BtnLoadSettings,DataView);
            cNet.LoadLogin(TXTServNameIP, txtUserName, txtPassword,CheckBoxW_authenticate);   
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            seting.Save(DataView);
        }


        private void button3_Click_2(object sender, EventArgs e)
        {
            DataView.Columns.Clear();
            cNet.Load(DataView);
        }

     


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Exit Application?", @"Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    cNet.ShareConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    e.Cancel = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //300000    
            if (timer1.Interval == 300000)
            { 
                timer1.Stop();
                timer2.Stop();
                cNet.TimedClocks(DataView, progressBar1, btnExport, timer1, timer2,ChkEXE);
                timeSet = new DateTime(2014, 01, 01, 0, 5, 0);
                label6.Text = "Next export in: " + timeSet.ToString("HH:mm:ss");
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            timeSet = timeSet.AddSeconds(-1);
            label6.Text = "Next export in: " + timeSet.ToString("HH:mm:ss");
            Application.DoEvents();
            if (label6.Text == "Next export in: 00:00:00")
            {
                timeSet = new DateTime(2014, 01, 01, 0, 5, 0);
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool authent = false;
            try
            {
                if (TXTServNameIP.Text == "")
                {
                    return;
                }

                if (CheckBoxW_authenticate.Checked) authent = true;
                else authent = false;

                try
                {
                    cNet.Dbconnection(txtPassword.Text, TXTServNameIP.Text, txtUserName.Text, authent,btnSave,btnViewDefault,btnExport,BtnLoadSettings,DataView,btnConnect);
                }
                catch (Exception)
                {
                    return;
                }

                seting.LoginSave(txtUserName.Text, TXTServNameIP.Text, txtPassword.Text, CheckBoxW_authenticate.CheckState.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBoxW_authenticate_CheckedChanged_1(object sender, EventArgs e)
        {
            tools.WindowsCheckd(txtPassword, txtUserName, CheckBoxW_authenticate);
        }

        private void btnRunFile_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(txtFileName.Text);
          

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            cNet.fileSave(ChkEXE.CheckState.ToString(),txtFileName);

            cNet.RunFile(ChkEXE);
            
        }

        private void ChkEXE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cNet.browser(txtFileName);
        }
    }
}
