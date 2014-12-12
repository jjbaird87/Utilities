using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Morpho.MorphoAccess.Maci;



namespace MorphoAccess
{
    public partial class Form1 : Form
    {
  
        private DatabaseProxy dbProxy;
        private DatabaseFormat DBformat;
        BioDataFormat format;
        private ConnectionType conType ;
        ApplicationProtocol proto = ApplicationProtocol.APPLICATION_MA2G;
        MorphoAccess morphoAccessDevice = new MorphoAccess();
        private string m_textBioMgr,
            m_textConfigProxy,
            m_textDbProxy,
            m_textCardEncoder,
       m_textKeyMgt,
       m_textLogProxy, 
       m_textScheduleMgr,
       m_textUserIface,
      m_prefixFFDSecurityLevel,
      m_prefixFVPSecurityLevel,
      m_prefixBioItemType, 
      m_prefixFactorySettings;


        private IDictionary<string, string> UserData;

        public Form1()
        {
            InitializeComponent();
            CmbConnectTyp.Items.AddRange(Enum.GetNames(ConnectionType.Serial.GetType()));
            CmbConnectTyp.SelectedIndex = 0;
  
            m_prefixFFDSecurityLevel = "FFD_SECURITY_LEVEL_";
            m_prefixFVPSecurityLevel = "FVP_SECURITY_LEVEL_";
            m_prefixBioItemType = "BIOITEM_TYPE_";
            m_prefixFactorySettings = "FACTORY_";

            UserData = new Dictionary<string, string>();
        
            string[] enumerationValueNames = Enum.GetNames(LogAction.LOG_ACTION_ADD_USER.GetType());
           
            // Enumeration for FFD_SECURITY_LEVEL_*
            enumerationValueNames = Enum.GetNames(FFDSecurityLevel.FFD_SECURITY_LEVEL_STANDARD.GetType());
            for (int i = 0; i < enumerationValueNames.Length; ++i)
            {
                enumerationValueNames[i] = enumerationValueNames[i].Substring(m_prefixFFDSecurityLevel.Length);
            }
            comboFFD.Items.AddRange(enumerationValueNames);
            // Enumeration for FVP_SECURITY_LEVEL_*
            enumerationValueNames = Enum.GetNames(FVPSecurityLevel.FVP_SECURITY_LEVEL_DEFAULT.GetType());
            for (int i = 0; i < enumerationValueNames.Length; ++i)
            {
                enumerationValueNames[i] = enumerationValueNames[i].Substring(m_prefixFVPSecurityLevel.Length);
            }
            comboFVP.Items.AddRange(enumerationValueNames);
            // Enumeration for BIOITEM_TYPE_*
            enumerationValueNames = Enum.GetNames(BioDataIdentifier.BIOITEM_TYPE_UNDEFINED.GetType());
            for (int i = 0; i < enumerationValueNames.Length; ++i)
            {
                enumerationValueNames[i] = enumerationValueNames[i].Substring(m_prefixBioItemType.Length);
            }
             
            comboFinger1Id.Items.AddRange(enumerationValueNames);
            comboFinger2Id.Items.AddRange(enumerationValueNames);
            comboDuressId.Items.AddRange(enumerationValueNames);
       
            enumerationValueNames = Enum.GetNames(FactoryResetSettings.FACTORY_ETHERNET.GetType());
            for (int i = 0; i < enumerationValueNames.Length; ++i)
            {
                enumerationValueNames[i] = enumerationValueNames[i].Substring(m_prefixFactorySettings.Length);
            }
        
            enumerationValueNames = Enum.GetNames(BioDataFormat.BIO_FORMAT_UNDEFINED.GetType());
            comboTemplateFormat.Items.AddRange(enumerationValueNames);
            comboTemplateFormat.Items.AddRange(enumerationValueNames);
      
            comboTemplateFormat.SelectedIndex = comboTemplateFormat.Items.Count - 1;
  
            comboFFD.SelectedIndex = 0;
            comboFVP.SelectedIndex = comboFVP.Items.Count - 1;
         
            comboFinger2Id.SelectedIndex = 0;
            comboFinger1Id.SelectedIndex = 0;
            comboDuressId.SelectedIndex = 0;
            
            morphoAccessDevice.FingerEvent += this.OnFingerEvent;
            morphoAccessDevice.EnrollmentEvent += this.OnEnrollmentEvent;
            morphoAccessDevice.QualityEvent += this.OnQualityEvent;
            morphoAccessDevice.ImageEvent += this.OnImageEvent; 
        }

        #region Implementation for live messages delegates
        private void OnFingerEvent(string position_message)
        {
            PositionMessage.Text = position_message;
        }
        private void OnEnrollmentEvent(int finger_index, int capture_index)
        {
            BioFingerIndex.Text = finger_index.ToString();
            BioCaptureIndex.Text = capture_index.ToString();
        }
        private void OnQualityEvent(int quality)
        {
            if (quality < QualityBar.Minimum)
            {
                QualityBar.Value = QualityBar.Minimum;
            }
            else if (quality > QualityBar.Maximum)
            {
                QualityBar.Value = QualityBar.Maximum;
            }
            else
            {
                QualityBar.Value = quality;
            }
        }
        private void OnImageEvent(byte[] vecbuffer, uint width, uint height)
        {
            // Displaying the image would be nice
        }
        #endregion


        private BioParameters GetBioParameters()
        {
            FFDSecurityLevel ffd;
            FVPSecurityLevel fvp;
            if (!Enum.TryParse(String.Concat(m_prefixFFDSecurityLevel, comboFFD.Text), out ffd))
            {
                ffd = FFDSecurityLevel.FFD_SECURITY_LEVEL_STANDARD;
            }
            if (!Enum.TryParse(String.Concat(m_prefixFVPSecurityLevel, comboFVP.Text), out fvp))
            {
                fvp = FVPSecurityLevel.FVP_SECURITY_LEVEL_DEFAULT;
            }
            return new BioParameters(ffd, fvp, Convert.ToUInt32(numQuality.Value),
                checkBoxJuvenile.Checked, checkBoxAdvSecurity.Checked, checkBoxLatent.Checked, checkBoxDuress.Checked);
        }

        private BioDataIdentifier GetBioDataId(ComboBox combo)
        {
            BioDataIdentifier result;
            if (!Enum.TryParse(String.Concat(m_prefixBioItemType, combo.Text), out result))
            {
                MessageBox.Show("Unknown bioitem identifier "+m_prefixBioItemType +" "+combo.Text+", using "
                    + BioDataIdentifier.BIOITEM_TYPE_UNDEFINED.ToString(),LogLevel.WARNING.ToString()
                    );
                result = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            }
            return result;
        }

        private LocalRecord GetBioManagerRecord()
        {
            BioDataFormat format;
            if (!Enum.TryParse(comboTemplateFormat.Text, out format))
            {
                format = BioDataFormat.BIO_FORMAT_UNDEFINED;
            }
            return new LocalRecord(TxtID.Text, TxtName.Text, TxtLastNAme.Text, format,
                TxtFinger.Text, TxtFinger2.Text, txtFingerDuressPath.Text,
                GetBioDataId(comboFinger1Id), GetBioDataId(comboFinger2Id), GetBioDataId(comboDuressId));
        }


        private LocalRecord forfullLAod()
        {
            BioDataFormat format;
            if (!Enum.TryParse(comboTemplateFormat.Text, out format))
            {
                format = BioDataFormat.BIO_FORMAT_UNDEFINED;
            }
            return new LocalRecord(TxtID.Text, TxtName.Text, TxtLastNAme.Text, format,
                TxtFinger.Text, TxtFinger2.Text, txtFingerDuressPath.Text,
                GetBioDataId(comboFinger1Id), GetBioDataId(comboFinger2Id), GetBioDataId(comboDuressId));
        }

        private LocalRecord GetDatabaseProxyRecord()
        {
            BioDataFormat format = BioDataFormat.BIO_FORMAT_UNDEFINED;
            if (!Enum.TryParse<BioDataFormat>(comboTemplateFormat.SelectedItem.ToString(), out format))
            {
                format = BioDataFormat.BIO_FORMAT_UNDEFINED;
            }
            return new LocalRecord(TxtID.Text, TxtName.Text, TxtLastNAme.Text, format,
                TxtFinger.Text, TxtFinger2.Text, txtFingerDuressPath.Text,
                GetBioDataId(comboFinger1Id), GetBioDataId(comboFinger2Id), GetBioDataId(comboDuressId),
                UserData);
        }


        private void BtnConnectD_Click(object sender, EventArgs e)
        {        
            Enum.TryParse<ConnectionType>(CmbConnectTyp.SelectedItem.ToString(), out conType);

            morphoAccessDevice.Connect(conType, proto, txtIP.AddressText, ushort.Parse(txtPort.Text), txtSerial.Text,
                txtSert.Text,txtClientCert.Text, txtCertPass.Text);

            morphoAccessDevice.Ping();
            morphoAccessDevice.CreateDatabaseProxy();
            morphoAccessDevice.CreateBioManager();
        }


        private void BtnAddUser_Click(object sender, EventArgs e)
        {

            try
            {
                UserData.Add("FNAME", TxtLastNAme.Text);
                UserData.Add("NAME",TxtName.Text);
                
                morphoAccessDevice.FullLoad(forfullLAod(),TxtFinger2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR");
                return;
            }

            morphoAccessDevice.AddRecord(GetDatabaseProxyRecord());



            //if (morphoAccessDevice.Enroll(GetBioManagerRecord(),
            //    Convert.ToUInt32(numPkSize.Value),
            //    Convert.ToUInt32(numFingers.Value),
            //    Convert.ToUInt32(numTimeout.Value),
            //    GetBioParameters()))
            //{
            //    morphoAccessDevice.CreateDatabaseProxy();

            //    morphoAccessDevice.AddUsers();

            //}
        }

        private void BtnFindFinger_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            TxtFinger.Text = openFile.FileName;
        }


        private void btnDbFingerDuress_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            txtFingerDuressPath.Text = openFile.FileName;
        }

        private void btnFindFinger2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            TxtFinger2.Text = openFile.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


     
        


    }
}

