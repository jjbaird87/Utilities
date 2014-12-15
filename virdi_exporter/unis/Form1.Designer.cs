namespace VIRDI_CLOCKING_COLLECTOR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConnectPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxW_authenticate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.TXTServNameIP = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnRun = new System.Windows.Forms.Button();
            this.ChkEXE = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewDefault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnLoadSettings = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ConnectPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGray;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(554, 292);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(77, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export .dat file";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 348);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConnectPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 235);
            this.tabControl1.TabIndex = 17;
            // 
            // ConnectPage
            // 
            this.ConnectPage.BackColor = System.Drawing.Color.Black;
            this.ConnectPage.Controls.Add(this.label3);
            this.ConnectPage.Controls.Add(this.CheckBoxW_authenticate);
            this.ConnectPage.Controls.Add(this.label2);
            this.ConnectPage.Controls.Add(this.label1);
            this.ConnectPage.Controls.Add(this.btnConnect);
            this.ConnectPage.Controls.Add(this.TXTServNameIP);
            this.ConnectPage.Controls.Add(this.txtUserName);
            this.ConnectPage.Controls.Add(this.txtPassword);
            this.ConnectPage.Location = new System.Drawing.Point(4, 22);
            this.ConnectPage.Name = "ConnectPage";
            this.ConnectPage.Size = new System.Drawing.Size(221, 209);
            this.ConnectPage.TabIndex = 0;
            this.ConnectPage.Text = "Database Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(2, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Server name:";
            // 
            // CheckBoxW_authenticate
            // 
            this.CheckBoxW_authenticate.AutoSize = true;
            this.CheckBoxW_authenticate.BackColor = System.Drawing.Color.Black;
            this.CheckBoxW_authenticate.ForeColor = System.Drawing.Color.Green;
            this.CheckBoxW_authenticate.Location = new System.Drawing.Point(38, 120);
            this.CheckBoxW_authenticate.Name = "CheckBoxW_authenticate";
            this.CheckBoxW_authenticate.Size = new System.Drawing.Size(140, 17);
            this.CheckBoxW_authenticate.TabIndex = 18;
            this.CheckBoxW_authenticate.Text = "Windows authentication";
            this.CheckBoxW_authenticate.UseVisualStyleBackColor = false;
            this.CheckBoxW_authenticate.CheckedChanged += new System.EventHandler(this.CheckBoxW_authenticate_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "User Name:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkGray;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(41, 159);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 34);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // TXTServNameIP
            // 
            this.TXTServNameIP.Location = new System.Drawing.Point(76, 11);
            this.TXTServNameIP.Name = "TXTServNameIP";
            this.TXTServNameIP.Size = new System.Drawing.Size(140, 20);
            this.TXTServNameIP.TabIndex = 12;
            this.TXTServNameIP.Text = "\r\n";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(76, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(76, 84);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 21);
            this.txtPassword.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.BtnRun);
            this.tabPage2.Controls.Add(this.ChkEXE);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtFileName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(221, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Execute file";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(60, 103);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(88, 34);
            this.BtnRun.TabIndex = 4;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // ChkEXE
            // 
            this.ChkEXE.AutoSize = true;
            this.ChkEXE.ForeColor = System.Drawing.Color.Green;
            this.ChkEXE.Location = new System.Drawing.Point(11, 59);
            this.ChkEXE.Name = "ChkEXE";
            this.ChkEXE.Size = new System.Drawing.Size(81, 17);
            this.ChkEXE.TabIndex = 2;
            this.ChkEXE.Text = "Execute file";
            this.ChkEXE.UseVisualStyleBackColor = true;
            this.ChkEXE.CheckedChanged += new System.EventHandler(this.ChkEXE_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(5, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "File:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(33, 33);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(142, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(6, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "TEL: 0861268000 \r\nEMAIL: SALES@ANVHOLDINGS.CO.ZA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(511, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Next export in: 00:00:00";
            // 
            // btnViewDefault
            // 
            this.btnViewDefault.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDefault.Location = new System.Drawing.Point(245, 292);
            this.btnViewDefault.Name = "btnViewDefault";
            this.btnViewDefault.Size = new System.Drawing.Size(106, 23);
            this.btnViewDefault.TabIndex = 10;
            this.btnViewDefault.Text = "Default settings";
            this.btnViewDefault.UseVisualStyleBackColor = false;
            this.btnViewDefault.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(453, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save settings";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnLoadSettings
            // 
            this.BtnLoadSettings.BackColor = System.Drawing.Color.DarkGray;
            this.BtnLoadSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLoadSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadSettings.Location = new System.Drawing.Point(355, 292);
            this.BtnLoadSettings.Name = "BtnLoadSettings";
            this.BtnLoadSettings.Size = new System.Drawing.Size(95, 23);
            this.BtnLoadSettings.TabIndex = 13;
            this.BtnLoadSettings.Text = "Load Settings";
            this.BtnLoadSettings.UseVisualStyleBackColor = false;
            this.BtnLoadSettings.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.AllowUserToResizeColumns = false;
            this.DataView.AllowUserToResizeRows = false;
            this.DataView.BackgroundColor = System.Drawing.Color.Green;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(255, 14);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(369, 273);
            this.DataView.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.ForestGreen;
            this.progressBar1.Location = new System.Drawing.Point(246, 324);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(105, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(352, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "COPYRIGHT ACTA NON VERBA HOLDINGS (PTY) LTD.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creaToolStripMenuItem.Text = "Create save location";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(641, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnLoadSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.btnViewDefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ANV HOLDINGS (PTY) LTD - VIRDI CLOCKING COLLECTOR ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ConnectPage.ResumeLayout(false);
            this.ConnectPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewDefault;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnLoadSettings;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConnectPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxW_authenticate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox TXTServNameIP;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ChkEXE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button button1;
    }
}

