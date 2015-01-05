using System;
using System.Collections.Generic;
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
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]

    public class UserDetails
    {
        string username = string.Empty;
        string Surname = string.Empty;
        int id = 0;
        byte template;

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
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public byte Template
        {
            get { return template; }
            set { template = value; }
        }
    }
}
