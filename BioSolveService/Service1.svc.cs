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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string InsertRecord(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Rajesh;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable(UserName,Password,Country,Email) values(@UserName,@Password,@Country,@Email)", con);
            cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
            cmd.Parameters.AddWithValue("@surname", userInfo.surname);
            cmd.Parameters.AddWithValue("@Id", userInfo.Id);
            cmd.Parameters.AddWithValue("@Template", userInfo.Template);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.UserName + " User inserted successfully";
            }
            else
            {
                Message = userInfo.UserName + " User not inserted successfully";
            }
            con.Close();
            return Message;
        }
    }
}
