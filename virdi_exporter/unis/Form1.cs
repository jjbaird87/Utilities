using System;
using System.Windows.Forms;


namespace unis 
{
    public partial class Form1 : Form
    {
        private DateTime timeLeft = new DateTime(2014, 01, 01, 0, 5, 0);

        private Dbconnect cNet = new Dbconnect();
        private Settings seting = new Settings();
        private ToolSettings tools = new ToolSettings();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    cNet.Dbconnection(txtPassword.Text, TXTServNameIP.Text, txtUserName.Text, authent);
                }
                catch (Exception)
                {
                    return;
                }

                tools.Connected(btnSave, btnViewDefault, btnExport, BtnLoadSettings, DataView, btnConnect);
                seting.LoginSave(txtUserName.Text, TXTServNameIP.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            cNet.Clocks(DataView, progressBar1, btnExport, timer1,timer2);
            label6.Text = @"Next export in: 00:00:00";
            timeLeft = new DateTime(2014, 01, 01, 0, 5, 0);
            Application.DoEvents();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DataView.Columns.Clear();
            cNet.loadDb_view(DataView);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tools.createDirectory();
            tools.FormLoader(btnSave, btnViewDefault, btnExport, BtnLoadSettings, DataView);
            cNet.LoadLogin(TXTServNameIP, txtUserName, txtPassword);
            button3_Click_2(sender, e);
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

        private void CheckBoxW_authenticate_CheckedChanged(object sender, EventArgs e)
        {
            tools.WindowsCheckd(txtPassword, txtUserName, CheckBoxW_authenticate);
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
               btnSave_Click(sender, e);
               cNet.TimedClocks(DataView, progressBar1, btnExport, timer1,timer2);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = @"Next export in: " + timeLeft.ToString("HH:mm:ss");
            if (label6.Text == @"Next export in: 00:00:00")
            {
                timeLeft = timeLeft.AddMinutes(5);
                label6.Text = @"Next export in: 00:00:00";
                timer2.Stop();
            }
            timeLeft = timeLeft.AddSeconds(-1);
            Application.DoEvents();
        }
    }
}
