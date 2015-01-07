using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BioSolveService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertRecord(UserDetails userInfo);

        [OperationContract]
        string UserLogin(UserDetails userInfo);

        [OperationContract]
        string DelteRecord(UserDetails userInfo);

        [OperationContract]
        SqlDataReader ViewRecords();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserDetails
    {
        private string username = string.Empty;
        private string Surname = string.Empty;
        private int idnum = 0;
        private byte[] template;
        private string password;

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }

        [DataMember]
        public int Idnum
        {
            get { return idnum; }
            set { idnum = value; }
        }

        [DataMember]
        public byte[] Template
        {
            get { return template; }
            set { template = value; }
        }
    }
}
