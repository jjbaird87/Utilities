using System;
using System.IO;
using System.Windows.Forms;

namespace unis
{
    class ToolSettings
    {
        public void FormLoader(Button btnSave, Button btnViewDefault, Button btnExport, Button btnLoadSettings, DataGridView dataView)
        {
            btnSave.Enabled = false;
            btnViewDefault.Enabled = false;
            btnExport.Enabled = false;
            btnViewDefault.Enabled = false;
            btnLoadSettings.Enabled = false;
            dataView.Enabled = false;        
        }


        public void WindowsCheckd(TextBox pass, TextBox user, CheckBox checkBoxW)
        {
            if (checkBoxW.Checked == true)
            {
                pass.Enabled = false;
                user.Enabled = false;
            }
            else
            {
                pass.Enabled = true;
                user.Enabled = true;
            }
        }


        public void Connected(Button btnSave, Button btnViewDefault, Button btnExport, Button btnLoadSettings, DataGridView dataView,Button connect)
        {
             btnSave.Enabled = true;
                btnViewDefault.Enabled = true;
                btnExport.Enabled = true;
                btnViewDefault.Enabled = true;
                btnLoadSettings.Enabled = true;
                dataView.Enabled = true;
            connect.Enabled = false;
        }
        

        public void createDirectory()
        {
            try
            {
                var path = @"C:\Users\Public\VIRDI CLOCKING";
                if (! Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
