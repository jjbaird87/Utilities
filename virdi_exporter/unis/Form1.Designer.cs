namespace unis
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
            this.TXTServNameIP = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxW_authenticate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewDefault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnLoadSettings = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTServNameIP
            // 
            this.TXTServNameIP.Location = new System.Drawing.Point(76, 53);
            this.TXTServNameIP.Name = "TXTServNameIP";
            this.TXTServNameIP.Size = new System.Drawing.Size(140, 20);
            this.TXTServNameIP.TabIndex = 0;
            this.TXTServNameIP.Text = "\r\n";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(76, 91);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(76, 126);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 16);
            this.txtPassword.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(41, 216);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 34);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(535, 291);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export .dat file";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CheckBoxW_authenticate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.TXTServNameIP);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 311);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Server name:";
            // 
            // CheckBoxW_authenticate
            // 
            this.CheckBoxW_authenticate.AutoSize = true;
            this.CheckBoxW_authenticate.Location = new System.Drawing.Point(41, 165);
            this.CheckBoxW_authenticate.Name = "CheckBoxW_authenticate";
            this.CheckBoxW_authenticate.Size = new System.Drawing.Size(140, 17);
            this.CheckBoxW_authenticate.TabIndex = 10;
            this.CheckBoxW_authenticate.Text = "Windows authentication";
            this.CheckBoxW_authenticate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name:";
            // 
            // btnViewDefault
            // 
            this.btnViewDefault.Location = new System.Drawing.Point(253, 291);
            this.btnViewDefault.Name = "btnViewDefault";
            this.btnViewDefault.Size = new System.Drawing.Size(81, 23);
            this.btnViewDefault.TabIndex = 10;
            this.btnViewDefault.Text = "Open default";
            this.btnViewDefault.UseVisualStyleBackColor = true;
            this.btnViewDefault.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(449, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnLoadSettings
            // 
            this.BtnLoadSettings.Location = new System.Drawing.Point(348, 291);
            this.BtnLoadSettings.Name = "BtnLoadSettings";
            this.BtnLoadSettings.Size = new System.Drawing.Size(85, 23);
            this.BtnLoadSettings.TabIndex = 13;
            this.BtnLoadSettings.Text = "Load Settings";
            this.BtnLoadSettings.UseVisualStyleBackColor = true;
            this.BtnLoadSettings.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.AllowUserToResizeColumns = false;
            this.DataView.AllowUserToResizeRows = false;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(253, 12);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(370, 273);
            this.DataView.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(635, 340);
            this.Controls.Add(this.BtnLoadSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.btnViewDefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTServNameIP;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDefault;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnLoadSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxW_authenticate;
    }
}

