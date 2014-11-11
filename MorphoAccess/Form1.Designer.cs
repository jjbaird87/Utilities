namespace MorphoAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.PositionMessage = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.BioCaptureIndex = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.BioFingerIndex = new System.Windows.Forms.TextBox();
            this.QualityBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTemplateFormat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboDuressId = new System.Windows.Forms.ComboBox();
            this.comboFinger2Id = new System.Windows.Forms.ComboBox();
            this.comboFinger1Id = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDbFingerDuress = new System.Windows.Forms.Button();
            this.txtFingerDuressPath = new System.Windows.Forms.TextBox();
            this.btnFindFinger2 = new System.Windows.Forms.Button();
            this.TxtFinger2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnFindFinger = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFinger = new System.Windows.Forms.TextBox();
            this.TxtLastNAme = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.tcpDevice = new System.Windows.Forms.GroupBox();
            this.CmbConnectTyp = new System.Windows.Forms.ComboBox();
            this.textBoxTimeout = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIP = new MorphoControls.IPv4InputBox();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConnectD = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.numMatchThreshold = new System.Windows.Forms.NumericUpDown();
            this.numFingers = new System.Windows.Forms.NumericUpDown();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.numPkSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxConsolidation = new System.Windows.Forms.CheckBox();
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.lblDuress = new System.Windows.Forms.Label();
            this.lblLatent = new System.Windows.Forms.Label();
            this.lblAdvSecurity = new System.Windows.Forms.Label();
            this.lblJuvenile = new System.Windows.Forms.Label();
            this.lblAcqThreshold = new System.Windows.Forms.Label();
            this.lblFVP = new System.Windows.Forms.Label();
            this.lblFFD = new System.Windows.Forms.Label();
            this.checkBoxDuress = new System.Windows.Forms.CheckBox();
            this.checkBoxLatent = new System.Windows.Forms.CheckBox();
            this.checkBoxAdvSecurity = new System.Windows.Forms.CheckBox();
            this.checkBoxJuvenile = new System.Windows.Forms.CheckBox();
            this.comboFVP = new System.Windows.Forms.ComboBox();
            this.comboFFD = new System.Windows.Forms.ComboBox();
            this.lblClientPassphrase = new System.Windows.Forms.Label();
            this.txtCertPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClientCert = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.Label();
            this.txtSert = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcpDevice.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFingers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPkSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnAddUser);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tcpDevice);
            this.tabPage1.Controls.Add(this.BtnConnectD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(331, 331);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(117, 61);
            this.BtnAddUser.TabIndex = 34;
            this.BtnAddUser.Text = "Add User";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PositionMessage);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.BioCaptureIndex);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.BioFingerIndex);
            this.groupBox8.Controls.Add(this.QualityBar);
            this.groupBox8.Location = new System.Drawing.Point(275, 99);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(238, 122);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Live informations";
            // 
            // PositionMessage
            // 
            this.PositionMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionMessage.Enabled = false;
            this.PositionMessage.Location = new System.Drawing.Point(56, 96);
            this.PositionMessage.Name = "PositionMessage";
            this.PositionMessage.Size = new System.Drawing.Size(176, 20);
            this.PositionMessage.TabIndex = 27;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 99);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 26;
            this.label29.Text = "Position";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 25;
            this.label28.Text = "Quality";
            // 
            // BioCaptureIndex
            // 
            this.BioCaptureIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BioCaptureIndex.Enabled = false;
            this.BioCaptureIndex.Location = new System.Drawing.Point(56, 45);
            this.BioCaptureIndex.Name = "BioCaptureIndex";
            this.BioCaptureIndex.Size = new System.Drawing.Size(176, 20);
            this.BioCaptureIndex.TabIndex = 24;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 23;
            this.label27.Text = "Capture";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "Finger";
            // 
            // BioFingerIndex
            // 
            this.BioFingerIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BioFingerIndex.Enabled = false;
            this.BioFingerIndex.Location = new System.Drawing.Point(56, 19);
            this.BioFingerIndex.Name = "BioFingerIndex";
            this.BioFingerIndex.Size = new System.Drawing.Size(176, 20);
            this.BioFingerIndex.TabIndex = 21;
            // 
            // QualityBar
            // 
            this.QualityBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityBar.Location = new System.Drawing.Point(56, 71);
            this.QualityBar.Maximum = 120;
            this.QualityBar.Name = "QualityBar";
            this.QualityBar.Size = new System.Drawing.Size(176, 19);
            this.QualityBar.Step = 1;
            this.QualityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.QualityBar.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTemplateFormat);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboDuressId);
            this.groupBox1.Controls.Add(this.comboFinger2Id);
            this.groupBox1.Controls.Add(this.comboFinger1Id);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDbFingerDuress);
            this.groupBox1.Controls.Add(this.txtFingerDuressPath);
            this.groupBox1.Controls.Add(this.btnFindFinger2);
            this.groupBox1.Controls.Add(this.TxtFinger2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnFindFinger);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFinger);
            this.groupBox1.Controls.Add(this.TxtLastNAme);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Location = new System.Drawing.Point(6, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 299);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New user";
            // 
            // comboTemplateFormat
            // 
            this.comboTemplateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemplateFormat.Location = new System.Drawing.Point(94, 272);
            this.comboTemplateFormat.Name = "comboTemplateFormat";
            this.comboTemplateFormat.Size = new System.Drawing.Size(149, 21);
            this.comboTemplateFormat.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Template format";
            // 
            // comboDuressId
            // 
            this.comboDuressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDuressId.FormattingEnabled = true;
            this.comboDuressId.Location = new System.Drawing.Point(84, 238);
            this.comboDuressId.Name = "comboDuressId";
            this.comboDuressId.Size = new System.Drawing.Size(159, 21);
            this.comboDuressId.TabIndex = 52;
            // 
            // comboFinger2Id
            // 
            this.comboFinger2Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinger2Id.FormattingEnabled = true;
            this.comboFinger2Id.Location = new System.Drawing.Point(84, 182);
            this.comboFinger2Id.Name = "comboFinger2Id";
            this.comboFinger2Id.Size = new System.Drawing.Size(159, 21);
            this.comboFinger2Id.TabIndex = 51;
            // 
            // comboFinger1Id
            // 
            this.comboFinger1Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFinger1Id.FormattingEnabled = true;
            this.comboFinger1Id.Location = new System.Drawing.Point(84, 126);
            this.comboFinger1Id.Name = "comboFinger1Id";
            this.comboFinger1Id.Size = new System.Drawing.Size(159, 21);
            this.comboFinger1Id.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Finger Duress";
            // 
            // btnDbFingerDuress
            // 
            this.btnDbFingerDuress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDbFingerDuress.Location = new System.Drawing.Point(218, 209);
            this.btnDbFingerDuress.Name = "btnDbFingerDuress";
            this.btnDbFingerDuress.Size = new System.Drawing.Size(24, 23);
            this.btnDbFingerDuress.TabIndex = 48;
            this.btnDbFingerDuress.Text = "...";
            this.btnDbFingerDuress.UseVisualStyleBackColor = true;
            this.btnDbFingerDuress.Click += new System.EventHandler(this.btnDbFingerDuress_Click);
            // 
            // txtFingerDuressPath
            // 
            this.txtFingerDuressPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFingerDuressPath.Location = new System.Drawing.Point(84, 211);
            this.txtFingerDuressPath.Name = "txtFingerDuressPath";
            this.txtFingerDuressPath.Size = new System.Drawing.Size(129, 20);
            this.txtFingerDuressPath.TabIndex = 47;
            this.txtFingerDuressPath.Text = "C:\\older\\fingerprint3.pkmat";
            // 
            // btnFindFinger2
            // 
            this.btnFindFinger2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindFinger2.Location = new System.Drawing.Point(218, 155);
            this.btnFindFinger2.Name = "btnFindFinger2";
            this.btnFindFinger2.Size = new System.Drawing.Size(24, 23);
            this.btnFindFinger2.TabIndex = 46;
            this.btnFindFinger2.Text = "...";
            this.btnFindFinger2.UseVisualStyleBackColor = true;
            this.btnFindFinger2.Click += new System.EventHandler(this.btnFindFinger2_Click);
            // 
            // TxtFinger2
            // 
            this.TxtFinger2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFinger2.Location = new System.Drawing.Point(84, 155);
            this.TxtFinger2.Name = "TxtFinger2";
            this.TxtFinger2.Size = new System.Drawing.Size(129, 20);
            this.TxtFinger2.TabIndex = 45;
            this.TxtFinger2.Text = "C:\\older\\fingerprint2.pkmat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Second Finger";
            // 
            // BtnFindFinger
            // 
            this.BtnFindFinger.Location = new System.Drawing.Point(218, 100);
            this.BtnFindFinger.Name = "BtnFindFinger";
            this.BtnFindFinger.Size = new System.Drawing.Size(25, 20);
            this.BtnFindFinger.TabIndex = 33;
            this.BtnFindFinger.Text = "...";
            this.BtnFindFinger.UseVisualStyleBackColor = true;
            this.BtnFindFinger.Click += new System.EventHandler(this.BtnFindFinger_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "First Finger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // TxtFinger
            // 
            this.TxtFinger.Location = new System.Drawing.Point(84, 101);
            this.TxtFinger.Name = "TxtFinger";
            this.TxtFinger.Size = new System.Drawing.Size(129, 20);
            this.TxtFinger.TabIndex = 29;
            this.TxtFinger.Text = "C:\\older\\fingerprint.pkmat";
            // 
            // TxtLastNAme
            // 
            this.TxtLastNAme.Location = new System.Drawing.Point(84, 71);
            this.TxtLastNAme.Name = "TxtLastNAme";
            this.TxtLastNAme.Size = new System.Drawing.Size(112, 20);
            this.TxtLastNAme.TabIndex = 28;
            this.TxtLastNAme.Text = "Mokwana";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(84, 45);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(112, 20);
            this.TxtName.TabIndex = 27;
            this.TxtName.Text = "Karabo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(84, 19);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(112, 20);
            this.TxtID.TabIndex = 25;
            this.TxtID.Text = "002";
            // 
            // tcpDevice
            // 
            this.tcpDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcpDevice.Controls.Add(this.CmbConnectTyp);
            this.tcpDevice.Controls.Add(this.textBoxTimeout);
            this.tcpDevice.Controls.Add(this.label7);
            this.tcpDevice.Controls.Add(this.txtIP);
            this.tcpDevice.Controls.Add(this.txtPort);
            this.tcpDevice.Controls.Add(this.label3);
            this.tcpDevice.Controls.Add(this.label4);
            this.tcpDevice.Location = new System.Drawing.Point(6, 15);
            this.tcpDevice.Name = "tcpDevice";
            this.tcpDevice.Padding = new System.Windows.Forms.Padding(10, 9, 10, 8);
            this.tcpDevice.Size = new System.Drawing.Size(342, 78);
            this.tcpDevice.TabIndex = 14;
            this.tcpDevice.TabStop = false;
            this.tcpDevice.Text = "MorphoAccess";
            // 
            // CmbConnectTyp
            // 
            this.CmbConnectTyp.FormattingEnabled = true;
            this.CmbConnectTyp.Location = new System.Drawing.Point(257, 16);
            this.CmbConnectTyp.Name = "CmbConnectTyp";
            this.CmbConnectTyp.Size = new System.Drawing.Size(75, 21);
            this.CmbConnectTyp.TabIndex = 18;
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(181, 47);
            this.textBoxTimeout.Mask = "99999";
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.PromptChar = ' ';
            this.textBoxTimeout.Size = new System.Drawing.Size(46, 20);
            this.textBoxTimeout.TabIndex = 17;
            this.textBoxTimeout.Text = "15";
            this.textBoxTimeout.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Timeout :";
            // 
            // txtIP
            // 
            this.txtIP.Address = ((System.Net.IPAddress)(resources.GetObject("txtIP.Address")));
            this.txtIP.AddressText = "192.168.1.25";
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIP.Location = new System.Drawing.Point(77, 16);
            this.txtIP.MinimumSize = new System.Drawing.Size(136, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.txtIP.Size = new System.Drawing.Size(174, 25);
            this.txtIP.TabIndex = 8;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(55, 47);
            this.txtPort.Mask = "99999";
            this.txtPort.Name = "txtPort";
            this.txtPort.PromptChar = ' ';
            this.txtPort.Size = new System.Drawing.Size(63, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "11010";
            this.txtPort.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Address";
            // 
            // BtnConnectD
            // 
            this.BtnConnectD.Location = new System.Drawing.Point(391, 31);
            this.BtnConnectD.Name = "BtnConnectD";
            this.BtnConnectD.Size = new System.Drawing.Size(82, 41);
            this.BtnConnectD.TabIndex = 0;
            this.BtnConnectD.Text = "Connect";
            this.BtnConnectD.UseVisualStyleBackColor = true;
            this.BtnConnectD.Click += new System.EventHandler(this.BtnConnectD_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.numMatchThreshold);
            this.tabPage3.Controls.Add(this.numFingers);
            this.tabPage3.Controls.Add(this.numTimeout);
            this.tabPage3.Controls.Add(this.numPkSize);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.checkBoxConsolidation);
            this.tabPage3.Controls.Add(this.numQuality);
            this.tabPage3.Controls.Add(this.lblDuress);
            this.tabPage3.Controls.Add(this.lblLatent);
            this.tabPage3.Controls.Add(this.lblAdvSecurity);
            this.tabPage3.Controls.Add(this.lblJuvenile);
            this.tabPage3.Controls.Add(this.lblAcqThreshold);
            this.tabPage3.Controls.Add(this.lblFVP);
            this.tabPage3.Controls.Add(this.lblFFD);
            this.tabPage3.Controls.Add(this.checkBoxDuress);
            this.tabPage3.Controls.Add(this.checkBoxLatent);
            this.tabPage3.Controls.Add(this.checkBoxAdvSecurity);
            this.tabPage3.Controls.Add(this.checkBoxJuvenile);
            this.tabPage3.Controls.Add(this.comboFVP);
            this.tabPage3.Controls.Add(this.comboFFD);
            this.tabPage3.Controls.Add(this.lblClientPassphrase);
            this.tabPage3.Controls.Add(this.txtCertPass);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtClientCert);
            this.tabPage3.Controls.Add(this.V);
            this.tabPage3.Controls.Add(this.txtSert);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtSerial);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(528, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 271);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 59;
            this.label24.Text = "Matching threshold";
            // 
            // numMatchThreshold
            // 
            this.numMatchThreshold.Location = new System.Drawing.Point(187, 269);
            this.numMatchThreshold.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numMatchThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMatchThreshold.Name = "numMatchThreshold";
            this.numMatchThreshold.Size = new System.Drawing.Size(62, 20);
            this.numMatchThreshold.TabIndex = 58;
            this.numMatchThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numFingers
            // 
            this.numFingers.Location = new System.Drawing.Point(187, 191);
            this.numFingers.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numFingers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFingers.Name = "numFingers";
            this.numFingers.Size = new System.Drawing.Size(62, 20);
            this.numFingers.TabIndex = 57;
            this.numFingers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(187, 243);
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(62, 20);
            this.numTimeout.TabIndex = 56;
            this.numTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPkSize
            // 
            this.numPkSize.Location = new System.Drawing.Point(187, 217);
            this.numPkSize.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numPkSize.Minimum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.numPkSize.Name = "numPkSize";
            this.numPkSize.Size = new System.Drawing.Size(62, 20);
            this.numPkSize.TabIndex = 55;
            this.numPkSize.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Minutiae Size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Timeout in Seconds (per capture)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(278, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Consolidated Acquisition (3 captures)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Number of fingers";
            // 
            // checkBoxConsolidation
            // 
            this.checkBoxConsolidation.AutoSize = true;
            this.checkBoxConsolidation.Location = new System.Drawing.Point(488, 87);
            this.checkBoxConsolidation.Name = "checkBoxConsolidation";
            this.checkBoxConsolidation.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConsolidation.TabIndex = 48;
            this.checkBoxConsolidation.UseVisualStyleBackColor = true;
            // 
            // numQuality
            // 
            this.numQuality.Location = new System.Drawing.Point(173, 156);
            this.numQuality.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numQuality.Name = "numQuality";
            this.numQuality.Size = new System.Drawing.Size(84, 20);
            this.numQuality.TabIndex = 47;
            this.numQuality.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblDuress
            // 
            this.lblDuress.AutoSize = true;
            this.lblDuress.Location = new System.Drawing.Point(278, 67);
            this.lblDuress.Name = "lblDuress";
            this.lblDuress.Size = new System.Drawing.Size(165, 13);
            this.lblDuress.TabIndex = 46;
            this.lblDuress.Text = "Acquire Duress Finger (additional)";
            // 
            // lblLatent
            // 
            this.lblLatent.AutoSize = true;
            this.lblLatent.Location = new System.Drawing.Point(278, 47);
            this.lblLatent.Name = "lblLatent";
            this.lblLatent.Size = new System.Drawing.Size(124, 13);
            this.lblLatent.TabIndex = 45;
            this.lblLatent.Text = "Detect Latent Fingerprint";
            // 
            // lblAdvSecurity
            // 
            this.lblAdvSecurity.AutoSize = true;
            this.lblAdvSecurity.Location = new System.Drawing.Point(278, 27);
            this.lblAdvSecurity.Name = "lblAdvSecurity";
            this.lblAdvSecurity.Size = new System.Drawing.Size(201, 13);
            this.lblAdvSecurity.TabIndex = 44;
            this.lblAdvSecurity.Text = "Request Advanced Security Compatibility";
            // 
            // lblJuvenile
            // 
            this.lblJuvenile.AutoSize = true;
            this.lblJuvenile.Location = new System.Drawing.Point(278, 7);
            this.lblJuvenile.Name = "lblJuvenile";
            this.lblJuvenile.Size = new System.Drawing.Size(99, 13);
            this.lblJuvenile.TabIndex = 43;
            this.lblJuvenile.Text = "Use Juvenile Coder";
            // 
            // lblAcqThreshold
            // 
            this.lblAcqThreshold.AutoSize = true;
            this.lblAcqThreshold.Location = new System.Drawing.Point(11, 159);
            this.lblAcqThreshold.Name = "lblAcqThreshold";
            this.lblAcqThreshold.Size = new System.Drawing.Size(143, 13);
            this.lblAcqThreshold.TabIndex = 42;
            this.lblAcqThreshold.Text = "Acquisition Quality Threshold";
            // 
            // lblFVP
            // 
            this.lblFVP.AutoSize = true;
            this.lblFVP.Location = new System.Drawing.Point(23, 130);
            this.lblFVP.Name = "lblFVP";
            this.lblFVP.Size = new System.Drawing.Size(68, 13);
            this.lblFVP.TabIndex = 41;
            this.lblFVP.Text = "FVP Security";
            // 
            // lblFFD
            // 
            this.lblFFD.AutoSize = true;
            this.lblFFD.Location = new System.Drawing.Point(23, 108);
            this.lblFFD.Name = "lblFFD";
            this.lblFFD.Size = new System.Drawing.Size(68, 13);
            this.lblFFD.TabIndex = 40;
            this.lblFFD.Text = "FFD Security";
            // 
            // checkBoxDuress
            // 
            this.checkBoxDuress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDuress.AutoSize = true;
            this.checkBoxDuress.Checked = true;
            this.checkBoxDuress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDuress.Location = new System.Drawing.Point(488, 67);
            this.checkBoxDuress.Name = "checkBoxDuress";
            this.checkBoxDuress.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDuress.TabIndex = 39;
            this.checkBoxDuress.UseVisualStyleBackColor = true;
            // 
            // checkBoxLatent
            // 
            this.checkBoxLatent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLatent.AutoSize = true;
            this.checkBoxLatent.Location = new System.Drawing.Point(488, 47);
            this.checkBoxLatent.Name = "checkBoxLatent";
            this.checkBoxLatent.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLatent.TabIndex = 38;
            this.checkBoxLatent.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdvSecurity
            // 
            this.checkBoxAdvSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdvSecurity.AutoSize = true;
            this.checkBoxAdvSecurity.Location = new System.Drawing.Point(488, 27);
            this.checkBoxAdvSecurity.Name = "checkBoxAdvSecurity";
            this.checkBoxAdvSecurity.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdvSecurity.TabIndex = 37;
            this.checkBoxAdvSecurity.UseVisualStyleBackColor = true;
            // 
            // checkBoxJuvenile
            // 
            this.checkBoxJuvenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxJuvenile.AutoSize = true;
            this.checkBoxJuvenile.Location = new System.Drawing.Point(488, 7);
            this.checkBoxJuvenile.Name = "checkBoxJuvenile";
            this.checkBoxJuvenile.Size = new System.Drawing.Size(15, 14);
            this.checkBoxJuvenile.TabIndex = 36;
            this.checkBoxJuvenile.UseVisualStyleBackColor = true;
            // 
            // comboFVP
            // 
            this.comboFVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFVP.FormattingEnabled = true;
            this.comboFVP.Location = new System.Drawing.Point(97, 127);
            this.comboFVP.Name = "comboFVP";
            this.comboFVP.Size = new System.Drawing.Size(141, 21);
            this.comboFVP.TabIndex = 35;
            // 
            // comboFFD
            // 
            this.comboFFD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFFD.FormattingEnabled = true;
            this.comboFFD.Location = new System.Drawing.Point(97, 105);
            this.comboFFD.Name = "comboFFD";
            this.comboFFD.Size = new System.Drawing.Size(130, 21);
            this.comboFFD.TabIndex = 34;
            // 
            // lblClientPassphrase
            // 
            this.lblClientPassphrase.AutoSize = true;
            this.lblClientPassphrase.Location = new System.Drawing.Point(11, 83);
            this.lblClientPassphrase.Name = "lblClientPassphrase";
            this.lblClientPassphrase.Size = new System.Drawing.Size(80, 13);
            this.lblClientPassphrase.TabIndex = 33;
            this.lblClientPassphrase.Text = "Certificate Pass";
            // 
            // txtCertPass
            // 
            this.txtCertPass.Location = new System.Drawing.Point(97, 80);
            this.txtCertPass.Name = "txtCertPass";
            this.txtCertPass.Size = new System.Drawing.Size(130, 20);
            this.txtCertPass.TabIndex = 32;
            this.txtCertPass.Text = "morpho";
            this.txtCertPass.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "client sert";
            // 
            // txtClientCert
            // 
            this.txtClientCert.Location = new System.Drawing.Point(97, 56);
            this.txtClientCert.Name = "txtClientCert";
            this.txtClientCert.Size = new System.Drawing.Size(130, 20);
            this.txtClientCert.TabIndex = 30;
            this.txtClientCert.Text = "MACI_all.pem";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(37, 34);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(54, 13);
            this.V.TabIndex = 29;
            this.V.Text = "Certificate";
            // 
            // txtSert
            // 
            this.txtSert.Location = new System.Drawing.Point(97, 31);
            this.txtSert.Name = "txtSert";
            this.txtSert.Size = new System.Drawing.Size(130, 20);
            this.txtSert.TabIndex = 28;
            this.txtSert.Text = "AC_list.pem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "serial port";
            // 
            // txtSerial
            // 
            this.txtSerial.AccessibleDescription = "COM1, COM2...";
            this.txtSerial.Location = new System.Drawing.Point(97, 5);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(130, 20);
            this.txtSerial.TabIndex = 26;
            this.txtSerial.Text = "COM1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcpDevice.ResumeLayout(false);
            this.tcpDevice.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatchThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFingers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPkSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnConnectD;
        private System.Windows.Forms.GroupBox tcpDevice;
        private MorphoControls.IPv4InputBox txtIP;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox textBoxTimeout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnFindFinger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFinger;
        private System.Windows.Forms.TextBox TxtLastNAme;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox comboDuressId;
        private System.Windows.Forms.ComboBox comboFinger2Id;
        private System.Windows.Forms.ComboBox comboFinger1Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDbFingerDuress;
        private System.Windows.Forms.TextBox txtFingerDuressPath;
        private System.Windows.Forms.Button btnFindFinger2;
        private System.Windows.Forms.TextBox TxtFinger2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbConnectTyp;
        private System.Windows.Forms.Label lblClientPassphrase;
        private System.Windows.Forms.TextBox txtCertPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClientCert;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.TextBox txtSert;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numMatchThreshold;
        private System.Windows.Forms.NumericUpDown numFingers;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.NumericUpDown numPkSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxConsolidation;
        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.Label lblDuress;
        private System.Windows.Forms.Label lblLatent;
        private System.Windows.Forms.Label lblAdvSecurity;
        private System.Windows.Forms.Label lblJuvenile;
        private System.Windows.Forms.Label lblAcqThreshold;
        private System.Windows.Forms.Label lblFVP;
        private System.Windows.Forms.Label lblFFD;
        private System.Windows.Forms.CheckBox checkBoxDuress;
        private System.Windows.Forms.CheckBox checkBoxLatent;
        private System.Windows.Forms.CheckBox checkBoxAdvSecurity;
        private System.Windows.Forms.CheckBox checkBoxJuvenile;
        private System.Windows.Forms.ComboBox comboFVP;
        private System.Windows.Forms.ComboBox comboFFD;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox PositionMessage;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox BioCaptureIndex;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox BioFingerIndex;
        private System.Windows.Forms.ProgressBar QualityBar;
        private System.Windows.Forms.ComboBox comboTemplateFormat;
        private System.Windows.Forms.Label label16;
    }
}

