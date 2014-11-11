using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Morpho.MorphoAccess.Maci;

namespace MorphoAccess
{
   
    public enum ConnectionType
    {
        TCP,
        SSL,
        Serial
    }

    public enum LogLevel
    {
        CRITICAL,
        ERROR,
        WARNING,
        INFO,
        VERBOSE,
        DEBUG
    }

    public class TerminalInfo
    {
        public TerminalInfo(string descriptor, string content)
        {
            this.m_descriptor = descriptor;
            this.m_content = content;
        }

        public string Descriptor
        {
            get { return m_descriptor; }
            set { m_descriptor = value; }
        }
        public string Content
        {
            get { return m_content; }
            set { m_content = value; }
        }
        private string m_descriptor;
        private string m_content;
    }

    public class LocalRecord
    {
        public LocalRecord(string id)
        {
            m_identifier = id;
            m_firstName = null;
            m_lastName = null;
            m_firstFingerURI = null;
            m_secondFingerURI = null;
            m_duressFingerURI = null;
            m_firstFingerId = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            m_secondFingerId = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            m_duressFingerId = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            m_templatesFormat = BioDataFormat.BIO_FORMAT_UNDEFINED;
            m_dicoUserData = new Dictionary<string, string>();
        }
        public LocalRecord(string id, string first_name, string last_name)
        {
            m_identifier = id;
            m_firstName = first_name;
            m_lastName = last_name;
            m_firstFingerURI = null;
            m_secondFingerURI = null;
            m_duressFingerURI = null;
            m_firstFingerId = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            m_secondFingerId = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            m_duressFingerId = BioDataIdentifier.BIOITEM_TYPE_UNDEFINED;
            m_templatesFormat = BioDataFormat.BIO_FORMAT_UNDEFINED;
            m_dicoUserData = new Dictionary<string, string>();
        }
        public LocalRecord(string id, string first_name, string last_name, BioDataFormat format,
            string uri_first_finger, string uri_second_finger, string uri_duress_finger,
            BioDataIdentifier id_first_finger, BioDataIdentifier id_second_finger, BioDataIdentifier id_duress_finger)
        {
            m_identifier = id;
            m_firstName = first_name;
            m_lastName = last_name;
            m_firstFingerURI = uri_first_finger;
            m_secondFingerURI = uri_second_finger;
            m_duressFingerURI = uri_duress_finger;
            m_firstFingerId = id_first_finger;
            m_secondFingerId = id_second_finger;
            m_duressFingerId = id_duress_finger;
            m_templatesFormat = format;
            m_dicoUserData = new Dictionary<string, string>();
        }
        public LocalRecord(string id, string first_name, string last_name, BioDataFormat format,
            string uri_first_finger, string uri_second_finger, string uri_duress_finger,
            BioDataIdentifier id_first_finger, BioDataIdentifier id_second_finger, BioDataIdentifier id_duress_finger,
            IDictionary<string, string> dico)
        {
            m_identifier = id;
            m_firstName = first_name;
            m_lastName = last_name;
            m_firstFingerURI = uri_first_finger;
            m_secondFingerURI = uri_second_finger;
            m_duressFingerURI = uri_duress_finger;
            m_firstFingerId = id_first_finger;
            m_secondFingerId = id_second_finger;
            m_duressFingerId = id_duress_finger;
            m_templatesFormat = format;
            m_dicoUserData = dico;
        }

        public string Identifier
        {
            get { return m_identifier; }
            set { m_identifier = value; }
        }
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string FirstFingerURI
        {
            get { return m_firstFingerURI; }
            set { m_firstFingerURI = value; }
        }
        public string SecondFingerURI
        {
            get { return m_secondFingerURI; }
            set { m_secondFingerURI = value; }
        }
        public string DuressFingerURI
        {
            get { return m_duressFingerURI; }
            set { m_duressFingerURI = value; }
        }
        public BioDataIdentifier FirstFingerIdentifier
        {
            get { return m_firstFingerId; }
            set { m_firstFingerId = value; }
        }
        public BioDataIdentifier SecondFingerIdentifier
        {
            get { return m_secondFingerId; }
            set { m_secondFingerId = value; }
        }
        public BioDataIdentifier DuressFingerIdentifier
        {
            get { return m_duressFingerId; }
            set { m_duressFingerId = value; }
        }
        public BioDataFormat TemplatesFormat
        {
            get { return m_templatesFormat; }
            set { m_templatesFormat = value; }
        }
        public IDictionary<string, string> UserData
        {
            get { return m_dicoUserData; }
            set { m_dicoUserData = value; }
        }

        private string m_identifier;
        private string m_firstName;
        private string m_lastName;
        private string m_firstFingerURI;
        private string m_secondFingerURI;
        private string m_duressFingerURI;
        private BioDataIdentifier m_firstFingerId;
        private BioDataIdentifier m_secondFingerId;
        private BioDataIdentifier m_duressFingerId;
        private BioDataFormat m_templatesFormat;
        private IDictionary<string, string> m_dicoUserData;
    }

    public class TerminalLog
    {
        public TerminalLog(string date, string action, string status, string userId)
        {
            this.m_date = date;
            this.m_action = action;
            this.m_status = status;
            this.m_userId = userId;
        }

        public string Date
        {
            get { return m_date; }
            set { m_date = value; }
        }
        public string Action
        {
            get { return m_action; }
            set { m_action = value; }
        }
        public string Status
        {
            get { return m_status; }
            set { m_status = value; }
        }
        public string UserId
        {
            get { return m_userId; }
            set { m_userId = value; }
        }
        private string m_date;
        private string m_action;
        private string m_status;
        private string m_userId;
    }

    public class BioParameters
    {
        public BioParameters(FFDSecurityLevel ffd, FVPSecurityLevel fvp,
            uint threshold, bool juvenile, bool adv_sec_level_compat,
            bool detect_latent, bool acquire_duress)
        {
            m_falseFingerDetectionLevel = ffd;
            m_fingerVPSecurityLevel = fvp;
            m_acquisitionQualityThreshold = threshold;
            m_juvenileCoder = juvenile;
            m_advancedSecurityLevelsCompatibility = adv_sec_level_compat;
            m_detectLatentFingerprint = detect_latent;
            m_acquireDuressFinger = acquire_duress;
        }

        public FFDSecurityLevel FalseFingerDetectionLevel
        {
            get { return m_falseFingerDetectionLevel; }
            set { m_falseFingerDetectionLevel = value; }
        }
        public FVPSecurityLevel FingerVPSecurityLevel
        {
            get { return m_fingerVPSecurityLevel; }
            set { m_fingerVPSecurityLevel = value; }
        }
        public uint AcquisitionQualityThreshold
        {
            get { return m_acquisitionQualityThreshold; }
            set { m_acquisitionQualityThreshold = value; }
        }
        public bool JuvenileCoder
        {
            get { return m_juvenileCoder; }
            set { m_juvenileCoder = value; }
        }
        public bool AdvancedSecurityLevelsCompatibility
        {
            get { return m_advancedSecurityLevelsCompatibility; }
            set { m_advancedSecurityLevelsCompatibility = value; }
        }
        public bool DetectLatentFingerprint
        {
            get { return m_detectLatentFingerprint; }
            set { m_detectLatentFingerprint = value; }
        }
        public bool AcquireDuressFinger
        {
            get { return m_acquireDuressFinger; }
            set { m_acquireDuressFinger = value; }
        }

        private FFDSecurityLevel m_falseFingerDetectionLevel;
        private FVPSecurityLevel m_fingerVPSecurityLevel;
        private uint m_acquisitionQualityThreshold;
        private bool m_juvenileCoder;
        private bool m_advancedSecurityLevelsCompatibility;
        private bool m_detectLatentFingerprint;
        private bool m_acquireDuressFinger;
    }

    class MorphoAccess
    {
        #region Delegates for live messages (in BioManager)
        // Declarations
        public delegate void FingerEventDelegate(string position_message);
        public delegate void EnrollmentEventDelegate(int finger_index, int capture_index);
        public delegate void QualityEventDelegate(int quality);
        public delegate void ImageEventDelegate(byte[] vecbuffer, uint width, uint height);

        // Definition
        public virtual event FingerEventDelegate FingerEvent;
        public virtual event EnrollmentEventDelegate EnrollmentEvent;
        public virtual event QualityEventDelegate QualityEvent;
        public virtual event ImageEventDelegate ImageEvent;
        #endregion Delegates for live messages (in BioManager)

        #region Terminal (Tab)
        #region Terminal Connection
        /// <summary>
        /// Connect to a MorphoAccess® terminal.
        /// </summary>
        /// <param name="type">Communication link.</param>
        /// <param name="termGeneration">Terminal 2nd generation (MA2G) or SIGMA.</param>
        /// <param name="host">Terminal hostname or IP address.</param>
        /// <param name="tcp_port">TCP connection port number.</param>
        /// <param name="serial_port">Serial port.</param>
        /// <param name="terminal_ca_path">Path to certificate authority for the MA certificate.</param>
        /// <param name="client_cert_path">Path to the client certificate for the PC.</param>
        /// <param name="client_cert_pw">Passphrase for the client certificate file.</param>
        /// <returns>true if connection was successful, false otherwise.</returns>
        public bool Connect(ConnectionType type, ApplicationProtocol termGeneration,
            string host, ushort tcp_port, string serial_port,
            string terminal_ca_path, string client_cert_path, string client_cert_pw)
        {
        
           ConnectionParameters connectParams;
            switch (type)
            {
                case ConnectionType.TCP:
                    connectParams = new TcpConnectionParameters(host, tcp_port);
                    break;
                case ConnectionType.SSL:
                    connectParams = new SslConnectionParameters(host, tcp_port, client_cert_path, client_cert_pw, terminal_ca_path);
                    break;
                case ConnectionType.Serial:
                    connectParams = new SerialConnectionParameters(serial_port);
                    break;
                default:
                    MessageBox.Show("Unknown method of connection.",LogLevel.ERROR.ToString());
                    return false;
            }
            try
            {
                m_terminal = new Terminal();
                m_terminal.Connect(connectParams, termGeneration);
                m_terminal.SetTimeoutInMs(15000);
            }
            catch (LicenceException)
            {
                MessageBox.Show( "MACI license is needed to use this application.",LogLevel.ERROR.ToString());
                return false;
            }
            catch (ConnectionFailedException)
            {
                MessageBox.Show( "Cannot connect to terminal.",LogLevel.ERROR.ToString());
                return false;
            }
            catch (MaciException e)
            {
                MessageBox.Show( String.Format("Failure occured in Maci : {0}", e.GetMessage(),LogLevel.ERROR.ToString()));
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show( String.Format("Failure occured : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
            m_application_protocol = termGeneration;


            MessageBox.Show("Successfully connected.", LogLevel.INFO.ToString());
            return true;
        }

        /// <summary>
        /// Disconnect the PC from the terminal.
        /// </summary>
        public void ResetConnection()
        {
            m_config_proxy = null;
            m_database_proxy = null;
            m_user_interface = null;
            m_external_links = null;
            m_encoder = null;
            m_log_proxy = null;
            m_bio_manager = null;
            m_key_management_system = null;
            m_schedule_manager = null;
            // A Terminal object cannot be used twice
            m_terminal = new Terminal();
        }
        #endregion // Terminal Connection

        #region Informations
        /// <summary>
        /// Read informations about the terminal in a list of (Descriptor, Content) elements.
        /// </summary>
        /// <returns>A list of TerminalInfo, empty list if there is no information known.</returns>
        public List<TerminalInfo> GetTerminalInfo()
        {
            List<TerminalInfo> list = new List<TerminalInfo>();
            string[] descriptors = m_terminal.GetDescriptors();
            foreach (string descriptor in descriptors)
            {
                list.Add(new TerminalInfo(descriptor, m_terminal.GetDescriptorValue(descriptor)));
            }
            return list;
        }
        #endregion // Informations

        #region Direct Actions
        /// <summary>
        /// Send the Ping command to the terminal and check answer.
        /// </summary>
        /// <returns>true if the terminal answered correctly, false otherwise.</returns>
        public bool Ping()
        {
            try
            {
                byte[] ping = Tools.UTF8StringToByteArray("ping");
                byte[] pong = m_terminal.Ping(ping);
                if (ping.Length != pong.Length)
                {
                  MessageBox.Show(
                        String.Format("Reply to ping ({0} bytes) was not the same as request ({1}).", ping.Length, pong.Length),LogLevel.WARNING.ToString());
                    return false;
                }
                for (int i = 0; i < ping.Length; ++i)
                {
                    if (ping[i] != pong[i])
                    {
                      MessageBox.Show(
                        String.Format("Reply to ping was different than request from byte {0}.", i),LogLevel.WARNING.ToString());
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
              MessageBox.Show(String.Format("Failure occured : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reboot the terminal.
        /// </summary>
        /// <returns>true if all commands were executed successfully, false otherwise.</returns>
        public bool Reboot()
        {
            try
            {
                m_terminal.Reboot();
            }
            catch (Exception e)
            {
              MessageBox.Show( String.Format("Failure occured : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reset the required settings on the terminal.
        /// </summary>
        /// <param name="settings">Array of settings to be resetted.</param>
        /// <returns>true if all commands were executed successfully, false otherwise.</returns>
        public bool FactoryReset(FactoryResetSettings[] settings)
        {
            try
            {
                m_terminal.FactoryReset(settings);
            }
            catch (MaciArgumentException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Invalid parameter for this terminal : {0}", e.GetMessage()));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured : {0}", e.Message));
                return false;
            }

            return true;
        }
        #endregion // Direct Actions

        #region Proxies
        public bool CreateBioManager()
        {
            try
            {
                m_bio_manager = m_terminal.CreateBioManager();
                MessageBox.Show("Setting callbacks...", LogLevel.DEBUG.ToString());
                m_bio_manager.SetImageCallback(this.OnImageEventHandler);
                m_bio_manager.SetFingerCallback(this.OnFingerEventHandler);
                m_bio_manager.SetQualityCallback(this.OnQualityEventHandler);
                m_bio_manager.SetEnrollmentCallback(this.OnEnrollEventHandler);
              MessageBox.Show( "... Callbacks set.",LogLevel.DEBUG.ToString());
            }
            catch (MaciException e)
            {
              MessageBox.Show( String.Format("Exception in MACI process : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show( String.Format("Generic Exception in process : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
          MessageBox.Show( "BioManager created.",LogLevel.VERBOSE.ToString());
            return true;
        }


        public void DeleteBioManager()
        {
            m_bio_manager.SetImageCallback(null);
            m_bio_manager.SetFingerCallback(null);
            m_bio_manager.SetQualityCallback(null);
            m_bio_manager.SetEnrollmentCallback(null);
            m_bio_manager = null;
          MessageBox.Show( "BioManager deleted.",LogLevel.VERBOSE.ToString());
        }

        public bool CreateConfigProxy()
        {
            try
            {
                m_config_proxy = m_terminal.CreateConfigProxy();
            }
            catch (MaciException e)
            {
              MessageBox.Show( String.Format("Exception in MACI process : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show( String.Format("Generic Exception in process : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
          MessageBox.Show( "ConfigProxy created.",LogLevel.VERBOSE.ToString());
            return true;
        }
        public void DeleteConfigProxy()
        {
            m_config_proxy = null;
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "ConfigProxy deleted.");
        }

        public bool CreateDatabaseProxy()
        {
            try
            {
                m_database_proxy = m_terminal.CreateDatabaseProxy(DEFAULT_DATABASE_ID); // First database (only 500 Series got several db)
                m_record_set = new RecordSet();
                if (m_application_protocol == ApplicationProtocol.APPLICATION_MA5G)
                {
                    m_db_format = m_database_proxy.GetFormat();
                }
                else
                {
            
                
                    // TODO handle the MA2G case
                }
            }
            catch (MaciException e)
            {
              MessageBox.Show( String.Format("Exception in MACI process : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Generic Exception in process : {0}", e.Message), LogLevel.ERROR.ToString());
                return false;
            }
       MessageBox.Show( "DatabaseProxy created.",LogLevel.VERBOSE.ToString());
     
            return true;
        }
        public void DeleteDatabaseProxy()
        {
            m_database_proxy = null;
            MessageBox.Show("DatabaseProxy deleted.", LogLevel.VERBOSE.ToString());
        }

        public bool CreateEncoder()
        {
            try
            {
                m_encoder = m_terminal.CreateCardEncoder(30); // in seconds (0 = no timeout)
            }
            catch (MaciException e)
            {
                MessageBox.Show(LogLevel.ERROR.ToString().ToString(), String.Format("Exception in MACI process : {0}", e.Message));
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(LogLevel.ERROR.ToString().ToString(), String.Format("Generic Exception in process : {0}", e.Message));
                return false;
            }
            MessageBox.Show(LogLevel.VERBOSE.ToString().ToString(), "Encoder created.");
            return true;
        }
        public void DeleteEncoder()
        {
            m_encoder = null;
            MessageBox.Show(LogLevel.VERBOSE.ToString().ToString(), "Encoder deleted.");
        }

        public bool CreateExternalLinks()
        {
            try
            {
                m_external_links = m_terminal.CreateExternalLinks();
            }
            catch (MaciException e)
            {
               MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
                return false;
            }
            catch (Exception e)
            {
               MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
                return false;
            }
           MessageBox.Show(LogLevel.VERBOSE.ToString(), "ExternalLinks created.");
            return true;
        }

        public void DeleteExternalLinks()
        {
            m_external_links = null;
           MessageBox.Show(LogLevel.VERBOSE.ToString().ToString(), "ExternalLinks deleted.");
        }

        public bool CreateKeyManagementSystem()
        {
            try
            {
                m_key_management_system = m_terminal.CreateKeyManagementSystem();
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
                return false;
            }
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "KeyManagementSystem created.");
            return true;
        }


        public void DeleteKeyManagementSystem()
        {
            m_key_management_system = null;
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "KeyManagementSystem deleted.");
        }


        public bool CreateLogProxy()
        {
            try
            {
                m_log_proxy = m_terminal.CreateLogProxy();
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
                return false;
            }
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "LogProxy created.");
            return true;
        }


        public void DeleteLogProxy()
        {
            m_log_proxy = null;
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "LogProxy deleted.");
        }


        public bool CreateScheduleManager()
        {
            try
            {
                m_schedule_manager = m_terminal.CreateScheduleManager();
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
                return false;
            }
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "ScheduleManager created.");
            return true;
        }


        public void DeleteScheduleManager()
        {
            m_schedule_manager = null;
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "ScheduleManager deleted.");
        }


        public bool CreateUserInterface()
        {
            try
            {
                m_user_interface = m_terminal.CreateUserInterface();
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
                return false;
            }
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "UserInterface created.");
            return true;
        }


        public void DeleteUserInterface()
        {
            m_user_interface = null;
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "UserInterface deleted.");
        }


        #endregion // Proxies
        #endregion // Terminal (Tab)

        #region Helpers
        private BioDataFormat ExtensionToBioDataFormat(string file_path)
        {
            // Update as openFileDlgTemplate
            string ext = Path.GetExtension(file_path);
            switch (ext)
            {
                #region From MSO_DemoDlg.cpp open file dialog
                case "pkc":
                    return BioDataFormat.PK_COMP_V2;
                case "pkcn":
                    return BioDataFormat.PK_COMP_NORM;
                case "pkmat":
                case "pkm":
                    return BioDataFormat.PK_MAT;
                case "pkmn":
                    return BioDataFormat.PK_MAT_NORM;
                case "ansi-fmr":
                case "ansi-fmr-2009":
                    return BioDataFormat.ANSI_378;
                case "minex-a":
                    return BioDataFormat.MINEX_A;
                case "iso-fmr":
                case "iso-fmr-2011":
                    return BioDataFormat.ISO_FMR;
                case "iso-fmc-ns":
                    return BioDataFormat.ISO_FMC_NS;
                case "iso-fmc-cs":
                    return BioDataFormat.ISO_FMC_CS;
                case "moc":
                    return BioDataFormat.PK_MOC;
                case "din-cs":
                    return BioDataFormat.DIN_V66400_CS;
                case "fvp":
                    return BioDataFormat.PK_FVP;
                case "fvp-m":
                    return BioDataFormat.PK_FVP_MATCH;
                /* NOT supported
                case "pks":
                    return BioDataFormat.PKS;
                case "tkb":
                    return BioDataFormat.Token Bio;
                case "pkv10":
                    return BioDataFormat.PKV10;*/
                #endregion
                #region Additional formats
                case "pklite":
                    return BioDataFormat.PKLITE;
                case "cfv":
                    return BioDataFormat.CFV;
                case "ilo-fmr":
                    return BioDataFormat.ILO_FMR;
                case "iso-fmc-cs-aa":
                    return BioDataFormat.ISO_FMC_CS_AA;
                case "din-cs-aa":
                    return BioDataFormat.DIN_V66400_CS_AA;
                #endregion
                /* No extension
                 * BIOSCRYPT (tem, tms, vur, bur, mtm?)
                 * MULTIMODAL_TEMPLATE_FORMAT (?)
                 * PK_ISO / PK_ISO_PARAM (for ANSI, ISO & ILO)
                 */
                default:
                  MessageBox.Show(LogLevel.WARNING.ToString(), String.Format("Extension not recognized. Using PKLITE format."));
                    return BioDataFormat.PKLITE;
            }
        }

        //public Record load(LocalRecord local_record)
        //{
            
        //}

        private Record ToMaciRecord(LocalRecord local_record)
        {
            var field = new DatabaseField();
            IRecord record = new Record(local_record.Identifier);

            if (!String.IsNullOrEmpty(local_record.FirstName))
            {
                record.SetUserDataField(MA5G_FIRST_NAME_IDENTIFIER, Tools.UTF8StringToByteArray(local_record.FirstName));
            }
            if (!String.IsNullOrEmpty(local_record.LastName))
            {
                record.SetUserDataField(MA5G_LAST_NAME_IDENTIFIER, Tools.UTF8StringToByteArray(local_record.LastName));
            }
            var elements = from row in local_record.UserData select new { Key = row.Key, Value = row.Value };



            foreach (var pair in elements)
            {
                switch (pair.Key)
                {
                    case MA5G_FIRST_NAME_IDENTIFIER:
                    case MA5G_LAST_NAME_IDENTIFIER:
                    case "PIN_code":
                    case "user_card_sn":
                    case "expiry_date":
                        // UTF-8 strings
                        record.SetUserDataField(pair.Key, Tools.UTF8StringToByteArray(pair.Value));
                        break;
                    case "white_list_flag":
                    case "VIP_list_flag":
                    case "apply_holiday_schedule":
                        // booleans
                        record.SetUserDataField(pair.Key, Tools.ToByteArray(Boolean.Parse(pair.Value)));
                        break;
                    case "schedule_nb":
                    case "user_role":
                        // bytes
                        record.SetUserDataField(pair.Key, Tools.ToByteArray(Byte.Parse(pair.Value)));
                        break;
                    case "job_code_list":
                    case "specific_relay_duration_in_sec":
                        // shorts
                        record.SetUserDataField(pair.Key, Tools.ToByteArray(Int16.Parse(pair.Value)));
                        break;
                    case "user_rule":
                    case "additional_data":
                        // binary data
                        record.SetUserDataField(pair.Key, Tools.HexadecimalStringToByteArray(pair.Value));
                        break;
                    case "legacy_timemask":
                        int TIMEMASK_LENGTH = 84;
                        byte[] timemask = new byte[TIMEMASK_LENGTH];
                        byte[] input_tm = Tools.HexadecimalStringToByteArray(pair.Value);
                        Array.Copy(input_tm, timemask, (input_tm.Length < TIMEMASK_LENGTH) ? input_tm.Length : TIMEMASK_LENGTH);
                        break;
                    case "legacy_extended_id":
                        int EXTENDED_ID_LENGTH = 64;
                        byte[] extended_id = new byte[EXTENDED_ID_LENGTH];
                        byte[] input_ei = Tools.HexadecimalStringToByteArray(pair.Value);
                        Array.Copy(input_ei, extended_id, (input_ei.Length < EXTENDED_ID_LENGTH) ? input_ei.Length : EXTENDED_ID_LENGTH);
                        break;
                       
                    default:
                      MessageBox.Show( String.Format("Field {0} unknown, using UTF-8 string format.", pair.Key));
                        record.SetUserDataField(pair.Key, Tools.UTF8StringToByteArray(pair.Value));
                        break;
                }
            }
            BioDataFormat format = local_record.TemplatesFormat;
            if ((local_record.FirstFingerURI != null) && (local_record.FirstFingerURI.Length != 0))
            {
                byte[] finger1 = Tools.ReadTemplate(local_record.FirstFingerURI);
                if (finger1.Length > 0)
                {
                    record.AddBioData(new BioData(new ByteVector(finger1), BioDataType.FINGERPRINT,
                        // If BioDataFormat is unknown, find out from file extension
                        (BioDataFormat.BIO_FORMAT_UNDEFINED != format) ? format : ExtensionToBioDataFormat(local_record.FirstFingerURI),
                        BioDataIdentifier.BIOITEM_TYPE_FLAT_RIGHT_FORE));
                }
            }
            if ((local_record.SecondFingerURI != null) && (local_record.SecondFingerURI.Length != 0))
            {
                byte[] finger2 = Tools.ReadTemplate(local_record.SecondFingerURI);
                if (finger2.Length > 0)
                {
                    record.AddBioData(new BioData(new ByteVector(finger2), BioDataType.FINGERPRINT,
                        (BioDataFormat.BIO_FORMAT_UNDEFINED != format) ? format : ExtensionToBioDataFormat(local_record.SecondFingerURI),
                        BioDataIdentifier.BIOITEM_TYPE_FLAT_LEFT_FORE));
                }
            }
            if ((local_record.DuressFingerURI != null) && (local_record.DuressFingerURI.Length != 0))
            {
                byte[] fingerd = Tools.ReadTemplate(local_record.DuressFingerURI);
                if (fingerd.Length > 0)
                {
                    record.AddBioData(new BioData(new ByteVector(fingerd), BioDataType.FINGERPRINT,
                        (BioDataFormat.BIO_FORMAT_UNDEFINED != format) ? format : ExtensionToBioDataFormat(local_record.DuressFingerURI),
                        BioDataIdentifier.BIOITEM_TYPE_UNDEFINED));
                }
            }
            return (record as Record);
        }


        private LocalRecord ToLocalRecord(Record maci_record)
        {
            LocalRecord record = new LocalRecord(maci_record.GetRecordId());
            foreach (string id in maci_record.GetUserDataNamesList())
            {
                byte[] value = maci_record.GetUserDataField(id).ToArray();
                switch (id)
                {
                    case MA5G_FIRST_NAME_IDENTIFIER:
                        record.FirstName = Tools.ToUTF8String(value);
                        break;
                    case MA5G_LAST_NAME_IDENTIFIER:
                        record.LastName = Tools.ToUTF8String(value);
                        break;
                    case "PIN_code":
                    case "user_card_sn":
                    case "expiry_date":
                        // UTF-8 strings
                        record.UserData.Add(id, Tools.ToUTF8String(value));
                        break;
                    case "white_list_flag":
                    case "VIP_list_flag":
                    case "apply_holiday_schedule":
                        // booleans
                        record.UserData.Add(id, Tools.ToBoolean(value).ToString());
                        break;
                    case "schedule_nb":
                    case "user_role":
                        // bytes
                        record.UserData.Add(id, Tools.ToByte(value).ToString());
                        break;
                    case "job_code_list":
                    case "specific_relay_duration_in_sec":
                        // shorts
                        record.UserData.Add(id, Tools.ToShort(value).ToString());
                        break;
                    case "user_rule":
                    case "additional_data":
                    case "legacy_timemask":
                    case "legacy_extended_id":
                        // binary data
                        record.UserData.Add(id, Tools.ToHexadecimalString(value));
                        break;
                    default:
                      MessageBox.Show(LogLevel.WARNING.ToString(), String.Format("Field {0} unknown, using UTF-8 string format.", id));
                        record.UserData.Add(id, Tools.ToUTF8String(value));
                        break;
                }
            }
            uint nb_bio = maci_record.GetBioDataListSize();
            uint current = 0;
            bool duress_not_found = true;
            while ((current < 2) && (current < nb_bio) && duress_not_found)
            {
                BioData bio_data = maci_record.GetBioData(current);
                if (BioDataFormat.BIO_FORMAT_UNDEFINED == record.TemplatesFormat)
                {
                    // Assuming all templates in the same format for a given user
                    record.TemplatesFormat = bio_data.GetFormat();
                }
                if (BioDataDuress.DURESS == bio_data.GetDuress())
                {
                    if (duress_not_found)
                    {
                        record.DuressFingerIdentifier = bio_data.GetIdentifier();
                        record.DuressFingerURI = String.Concat(Tools.URI_HEXADECIMAL_STRING, Tools.ToHexadecimalString(bio_data.GetData().ToArray()));
                        duress_not_found = false;
                    }
                }
                else if (current == 0)
                {
                    record.FirstFingerIdentifier = bio_data.GetIdentifier();
                    record.FirstFingerURI = String.Concat(Tools.URI_HEXADECIMAL_STRING, Tools.ToHexadecimalString(bio_data.GetData().ToArray()));
                    current = 1;
                }
                else if (current == 1)
                {
                    record.SecondFingerIdentifier = bio_data.GetIdentifier();
                    record.SecondFingerURI = String.Concat(Tools.URI_HEXADECIMAL_STRING, Tools.ToHexadecimalString(bio_data.GetData().ToArray()));
                    current = 2;
                }
            }
            return record;
        }
        #endregion Helpers

        #region BioManager (Tab)
        /// <summary>
        /// Acquire fingerprint template(s) for a user without storing it in the terminal biometric database.
        /// </summary>
        /// <param name="biometric_format">Format for the template.</param>
        /// <param name="export_minutiae_size">Size of the exported template if applicable.</param>
        /// <param name="biometric_data_count">Number of templates to acquire.</param>
        /// <param name="enrollment_type">Indicate if the acquisition must be consolidated.</param>
        /// <param name="timeout">Timeout for each fingerprint image capture in seconds.</param>
        /// <param name="bio_params">List of parameters for the BioManager.</param>
        /// <returns>true if all commands were executed successfully, false otherwise.</returns>
        public bool Acquire(BioDataFormat biometric_format, uint export_minutiae_size, uint biometric_data_count, EnrollmentType enrollment_type, uint timeout, BioParameters bio_params)
        {
            #region ajust minutiae size against template format
            // Prevent failure in conversions
            uint minutiae_size; // requested size set in the enroll command
            switch (biometric_format)
            {
                case BioDataFormat.BIO_FORMAT_UNDEFINED:
                    // No export is impossible for an acquisition
                  MessageBox.Show(LogLevel.ERROR.ToString(), "You must specify a template format for an acquisition.");
                    return false;
                case BioDataFormat.PK_COMP_V2:
                case BioDataFormat.PK_COMP_NORM:
                    minutiae_size = export_minutiae_size;
                    break;
                default:
                    // Activate export, size cannot be specified
                    minutiae_size = 1;
                    break;
            }
            #endregion ajust minutiae size against template format
            try
            {
                m_bio_last_acquisition = m_bio_manager.Acquire(biometric_format, minutiae_size, biometric_data_count, enrollment_type, timeout);
            }
            catch (CommunicationTimeoutException)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), "Timeout during enrollment process.");
                return false;
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured in Maci : {0}", e.GetMessage()));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured : {0}", e.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Enroll a user and store his fingerprint and details in the terminal database.
        /// </summary>
        /// <param name="local_record">The details about the user.</param>
        /// <param name="biometric_format">Format for the template.</param>
        /// <param name="export_minutiae_size">Size of the exported template if applicable.</param>
        /// <param name="biometric_data_count">Number of templates to acquire.</param>
        /// <param name="timeout">Timeout for each fingerprint image capture in seconds.</param>
        /// <param name="bio_params">List of parameters for the BioManager.</param>
        /// <returns>true if all commands were executed successfully, false otherwise.</returns>
        /// 
        /// 
       
        public bool Enroll(LocalRecord local_record, uint export_minutiae_size, uint biometric_data_count, uint timeout, BioParameters bio_params)
        {
            #region ajust minutiae size against template format
            // Prevent failure in conversions
            uint minutiae_size; // requested size set in the enroll command
            BioDataFormat internal_format; // requested template format in the enroll command and records
            switch (local_record.TemplatesFormat)
            {
                case BioDataFormat.BIO_FORMAT_UNDEFINED:
                    // No export
                    minutiae_size = 0;
                    internal_format = BioDataFormat.PKLITE;
                    break;
                case BioDataFormat.PK_COMP_V2:
                case BioDataFormat.PK_COMP_NORM:
                    minutiae_size = export_minutiae_size;
                    internal_format = local_record.TemplatesFormat;
                    break;
                default:
                    // Activate export, size cannot be specified
                    minutiae_size = 1;
                    internal_format = local_record.TemplatesFormat;
                    break;
            }
            #endregion ajust minutiae size against template format
            Record record = ToMaciRecord(local_record); // BioDataFormat only used when paths are != null
            m_bio_manager.SetAcquireDuressFinger(bio_params.AcquireDuressFinger);
            m_bio_manager.SetAcquisitionQualityThreshold(bio_params.AcquisitionQualityThreshold);
            m_bio_manager.SetSecurityLevelCompatibility(bio_params.AdvancedSecurityLevelsCompatibility
                ?AdvancedSecurityLevelsCompatibility.ENABLED
                :AdvancedSecurityLevelsCompatibility.DISABLED);
            m_bio_manager.SetFingerprintLatentDetection(bio_params.DetectLatentFingerprint
                ?FingerprintLatentDetection.LATENT_DETECTION_ENABLED
                :FingerprintLatentDetection.LATENT_DETECTION_DISABLED);
            m_bio_manager.SetFFDSecurityLevel(bio_params.FalseFingerDetectionLevel);
            m_bio_manager.SetFVPSecurityLevel(bio_params.FingerVPSecurityLevel);
            m_bio_manager.SetBiometricCoder(bio_params.JuvenileCoder
                ?BiometricCoder.JUVENILE_CODER_MODE
                :BiometricCoder.DEFAULT_CODER_MODE);
            record.AddBioData(new BioData(new ByteVector(), BioDataType.FINGERPRINT, internal_format, local_record.FirstFingerIdentifier));
            if (biometric_data_count >= 2)
            {
                record.AddBioData(new BioData(new ByteVector(), BioDataType.FINGERPRINT, internal_format, local_record.SecondFingerIdentifier));
            }
            if (bio_params.AcquireDuressFinger)
            {
                record.AddBioData(new BioData(new ByteVector(), BioDataType.FINGERPRINT, internal_format, local_record.DuressFingerIdentifier));
            }
            DatabaseProxy db_proxy = m_terminal.CreateDatabaseProxy(DEFAULT_DATABASE_ID);
            try
            {
                m_bio_last_enrollment = m_bio_manager.Enroll(record, db_proxy.GetFormat(), internal_format, minutiae_size, biometric_data_count, DEFAULT_DATABASE_ID, timeout);
            }
            catch (CommunicationTimeoutException)
            {
              MessageBox.Show( "Timeout during enrollment process.",LogLevel.ERROR.ToString());
                return false;
            }
            catch (MaciException e)
            {
              MessageBox.Show( String.Format("Failure occured in Maci : {0}", e.GetMessage()),LogLevel.ERROR.ToString());
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(String.Format("Failure occured : {0}", e.Message),LogLevel.ERROR.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Acquire a user's fingerprint and compare it to the given record.
        /// </summary>
        /// <param name="record">The details about the user.</param>
        /// <param name="finger_1_path">Path to the template for the first fingerprint template.</param>
        /// <param name="finger_2_path">Path to the template for the second fingerprint template.</param>
        /// <param name="matching_threshold">Minimum threshold to consider the acquired fingerprint is a match.</param>
        /// <param name="timeout">Timeout for each fingerprint image capture in seconds.</param>
        /// <param name="bio_params">List of parameters for the BioManager.</param>
        /// <returns>true if all commands were executed successfully, false otherwise.</returns>
        public bool Verify(LocalRecord local_record, uint matching_threshold, uint timeout, BioParameters bio_params)
        {
            Record reference = ToMaciRecord(local_record);
            try
            {
                m_bio_last_verification = m_bio_manager.Verify(reference, matching_threshold, ReturnMatchingScore.MATCHING_SCORE_DISABLED, timeout);
            }
            catch (CommunicationTimeoutException)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), "Timeout during enrollment process.");
                return false;
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured in Maci : {0}", e.GetMessage()));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured : {0}", e.Message));
                return false;
            }
            return true;
        }

        /// <summary>
        /// Acquire a user's fingerprint and proceed to an identification against the terminal biometric database.
        /// </summary>
        /// <param name="matching_threshold">Minimum threshold to consider the acquired fingerprint is a match.</param>
        /// <param name="timeout">Timeout for each fingerprint image capture in seconds.</param>
        /// <param name="bio_params">List of parameters for the BioManager.</param>
        /// <returns>true if all commands were executed successfully, false otherwise.</returns>
        public bool Identify(uint matching_threshold, uint timeout, BioParameters bio_params)
        {
            try
            {
                m_bio_last_identification = m_bio_manager.Identify(DEFAULT_DATABASE_ID,
                    m_terminal.CreateDatabaseProxy(DEFAULT_DATABASE_ID).GetFormat(),
                    matching_threshold, ReturnMatchingScore.MATCHING_SCORE_DISABLED, timeout);
            }
            catch (CommunicationTimeoutException)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), "Timeout during enrollment process.");
                return false;
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured in Maci : {0}", e.GetMessage()));
                return false;
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Failure occured : {0}", e.Message));
                return false;
            } 
            return true;
        }


        #region Live messages (Maci delegates implementations)


        private void OnImageEventHandler(byte[] vecbuffer, int width, int horizontal_resolution, int height, int vertical_resolution, ImageCompressionAlgorithm compression_algorithm, int bits_per_pixel)
        {
            // These cases cannot be handled by MorphoAcquisition, even though they should not happen
            if ((horizontal_resolution == vertical_resolution) &&
                (ImageCompressionAlgorithm.COMPRESSION_NONE == compression_algorithm) &&
                (GRAYSCALE_DEPTH_IN_BITS_PER_PIXEL == bits_per_pixel))
            {
                // 1. With MSO, CBM, MSI, CBI, FVP and current Bioscrypt sensors,
                //    full image resolution is 500 dpi horizontally AND vertically
                //    small live image reolution is 250 dpi horizontally AND vertically on supporting devices
                // 2. V1 has been abandonned and WSQ only exists on very specific sensor (not integrated with any MA)
                // 3. Less than 8 bits per pixels is only used with CBM, MSO and FVP on serial link
                //    MA2G do not send live images
                //    MA5G use CBI and MSI, not CBM and MSO, and integrate FVP with USB
                // Send image event
                ImageEvent(vecbuffer, (uint)width, (uint)height);
            }
        }

        private void OnFingerEventHandler(FingerEventStatus FingerPosition)
        {
            FingerEvent(FingerPosition.ToString());
        }

        private void OnQualityEventHandler(int value)
        {
            if ((int)byte.MaxValue < value)
            {
                // Actually, quality cannot go over 255 but theorytically, it is possible
                // (an MA SIGMA interface is able to give it)
                QualityEvent(byte.MaxValue);
            }
            else if ((int)byte.MinValue <= value)
            {
                QualityEvent((byte)value);
            }
            else
            {
                // should never happen at all
                QualityEvent(byte.MinValue);
            }
        }

        private void OnEnrollEventHandler(int finger_index, int capture_index)
        {
          MessageBox.Show(LogLevel.DEBUG.ToString(), String.Format("MAD;Finger {0}, capture {1}", finger_index, capture_index));
            // MorphoAcquisition only handle one-finger enrollment
            EnrollmentEvent(finger_index, capture_index);
        }
        #endregion Live messages
        #endregion // BioManager (Tab)

        #region DatabaseProxy (Tab)
        public bool AddRecord(LocalRecord local_record)
        {
            m_record_set.Add(ToMaciRecord(local_record));
            // TODO
          MessageBox.Show(LogLevel.WARNING.ToString(), "AddRecord does not catch exceptions");
            return false;
        }

        public LocalRecord GetRecord(string id)
        {
            LocalRecord record = ToLocalRecord(m_record_set.GetRecord(id));
            // TODO
          MessageBox.Show(LogLevel.WARNING.ToString(), "GetRecord does not catch exceptions");
            return record;
        }

        public bool RemoveRecord(string id)
        {
            m_record_set.Remove(id);
            // TODO
          MessageBox.Show(LogLevel.CRITICAL.ToString(), "RemoveRecord does not catch exceptions");
            return true;
        }

        public bool CreateDatabase()
        {
            // TODO
          MessageBox.Show(LogLevel.CRITICAL.ToString(), "CreateDatabase Not Implemented Yet");
            return false;
        }

        public bool DestroyDatabase()
        {
            // TODO
          MessageBox.Show(LogLevel.CRITICAL.ToString(), "DestroyDatabase Not Implemented Yet");
            return false;
        }

        public bool EraseDatabase()
        {
            m_database_proxy.EraseDatabase();
            // TODO
          MessageBox.Show(LogLevel.WARNING.ToString(), "EraseDatabase does not catch exceptions");
            return false;
        }





        public bool AddUsers()
        {
            try
            {
  IStatusSet status_set = new StatusSet();
            status_set = m_database_proxy.AddUsers(m_record_set as RecordSet);
                return true;
            }
            catch (Exception)
            {
                   
          MessageBox.Show( "AddUsers does neither catch exceptions nor handle returned status",LogLevel.WARNING.ToString());
            return false;
               
            }
          
  
            // TODO
       
        }

        public bool RemoveUsers()
        {
            StringVector user_ids = new StringVector((int)m_record_set.Count());
            IRecordSetIterator it = m_record_set.Iterator();
            while (it.HasNext())
            {
                user_ids.Add(it.Next().GetRecordId());
            }
            IStatusSet status_set = m_database_proxy.RemoveUsers(user_ids);
            // TODO
          MessageBox.Show( "RemoveUsers does neither catch exceptions nor handle returned status",LogLevel.WARNING.ToString());
            return false;
        }

        public bool UpdateTerminal()
        {
            IStatusSet status_set = m_database_proxy.UpdateTerminal(m_record_set as RecordSet);
            // TODO
          MessageBox.Show( "UpdateTerminal does neither catch exceptions nor handle returned status",LogLevel.WARNING.ToString());
            return false;
        }

        public bool UpdatePublicFields()
        {
            IStatusSet status_set = m_database_proxy.UpdatePublicFields(m_record_set as RecordSet);
            // TODO
            MessageBox.Show("UpdatePublicFields does neither catch exceptions nor handle returned status", LogLevel.WARNING.ToString());
            return false;
        }
        #endregion // DatabaseProxy (Tab)

        #region ConfigProxy (Tab)
        #endregion // ConfigProxy (Tab)

        #region Encoder (Tab)
        #endregion // Encoder (Tab)

        #region ExternalLinks (Tab)
        #endregion // ExternalLinks (Tab)

        #region KeyManagementSystem (Tab)
        #endregion // KeyManagementSystem (Tab)

        #region LogProxy (Tab)
        public void DeleteAllLogs()
        {
            try
            {
                m_log_proxy.EraseLog();
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
            }
          MessageBox.Show(LogLevel.VERBOSE.ToString(), "Logs deleted.");
        }

        public List<TerminalLog> RetrieveLogs(  OperationLogFilter filter,
                                                LogAction action,
                                                OperationLogStatus status, 
                                                string userId, 
                                                string fromDate, 
                                                string toDate, 
                                                bool photo)
        {
            List<TerminalLog> list = new List<TerminalLog>();
            try
            {
                Criteria criteria = new Criteria();
                criteria.SetFilter(filter);
                switch (filter)
                {
                    case OperationLogFilter.ACTION_STATUS:
                        criteria.SetActionStatus(status);
                        break;
                    case OperationLogFilter.DATE_TIME:
                        criteria.SetDateFrom(fromDate);
                        criteria.SetDateTo(toDate);
                        break;
                    case OperationLogFilter.LOG_ACTION:
                        criteria.SetLogAction(action);
                        break;
                    case OperationLogFilter.PHOTO_STATUS:
                        criteria.SetPhotoStatus(photo);
                        break;
                    case OperationLogFilter.USER_ID:
                        criteria.SetUserId(userId);
                        break;
                    case OperationLogFilter.ALL:
                    default:
                        break;
                }
                LogInterpreter interpreter = m_log_proxy.RetrieveLogs(criteria, m_log_proxy.GetAvailableLogFields());
                LogIterator it = interpreter.Iterator();

                while (it.HasNext())
                {
                    Ma5gTransactionLogEntry entry = it.Next() as Ma5gTransactionLogEntry;
                    list.Add(new TerminalLog(   entry.GetDate(),
                                                entry.GetAction().ToString(),
                                                entry.GetActionStatus().ToString(),
                                                entry.GetUserId()));
                }
              MessageBox.Show(LogLevel.VERBOSE.ToString(), "Logs retrieved.");
            }
            catch (MaciException e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Exception in MACI process : {0}", e.Message));
            }
            catch (Exception e)
            {
              MessageBox.Show(LogLevel.ERROR.ToString(), String.Format("Generic Exception in process : {0}", e.Message));
            }
            
            return list;
        }
        #endregion // LogProxy (Tab)

        #region ScheduleManager (Tab)
        #endregion // ScheduleManager (Tab)

        #region UserInterface (Tab)
        #endregion // UserInterface (Tab)

        #region Members
        private ITerminal m_terminal;
        private IConfigProxy m_config_proxy;
        private IDatabaseProxy m_database_proxy;
        private IUserInterface m_user_interface;
        private IExternalLinks m_external_links;
        private IEncoder m_encoder;
        private ILogProxy m_log_proxy;
        private IBioManager m_bio_manager;
        private IKeyManagementSystem m_key_management_system;
        private IScheduleManager m_schedule_manager;

        private ApplicationProtocol m_application_protocol;

        #region BioManager results
        private IAcquisitionResult m_bio_last_acquisition;
        private IEnrollmentResult m_bio_last_enrollment;
        private IVerificationResult m_bio_last_verification;
        private IIdentificationResult m_bio_last_identification;
        #endregion

        #region DatabaseProxy members
        private IDatabaseFormat m_db_format;
        private IRecordSet m_record_set;
        #endregion

      

        // constants
        private const uint DEFAULT_DATABASE_ID = 0;
        private const int GRAYSCALE_DEPTH_IN_BITS_PER_PIXEL = 8;
        private const string MA5G_FIRST_NAME_IDENTIFIER = "first_name";
        private const string MA5G_LAST_NAME_IDENTIFIER = "name";
        #endregion // Members


    }
}
