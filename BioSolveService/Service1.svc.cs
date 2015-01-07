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

        public SqlDataReader ViewRecords()
        {
            SqlConnection con =
            new SqlConnection(
                @"Data Source=KARABO_LAPTOP\SQLEXPRESS;Integrated Security=True;Initial Catalog= BioSolveWebClient.database");

            SqlCommand sqlCommand = new SqlCommand("select IdNum,UserName,LastName from [BiosolveUsers]", con);
            con.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            return reader;
        }

        public string InsertRecord(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection(@"Data Source=KARABO_LAPTOP\SQLEXPRESS;Integrated Security=True;Initial Catalog= BioSolveWebClient.database");
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("insert into BiosolveUsers(idNum,UserName,Lastname,Template,Password) values(@idNum,@UserName,@Lastname,@Template,@Password)", con);
            cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
            cmd.Parameters.AddWithValue("@Lastname", userInfo.surname);
            cmd.Parameters.AddWithValue("@idNum", userInfo.Idnum);
            cmd.Parameters.AddWithValue("@Template", userInfo.Template);
            cmd.Parameters.AddWithValue("@Password", userInfo.Password);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.UserName + "Record inserted successfully";
            }
            else
            {
                Message = userInfo.UserName + "Record not inserted successfully";
            }
            con.Close();
            return Message;
        }


        public string DelteRecord(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection(@"Data Source=KARABO_LAPTOP\SQLEXPRESS;Integrated Security=True;Initial Catalog= BioSolveWebClient.database");
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("delete from BiosolveUsers where idNum = '"+ userInfo.Idnum+"' and UserName = '"+userInfo.Idnum+"'", con);
           
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.UserName + " Record deleted successfully";
            }
            else
            {
                Message = userInfo.UserName + " Record not deleted successfully";
            }
            con.Close();
            return Message;
        }


        public string UserLogin(UserDetails user)
        {
            string message;
            SqlConnection con = new SqlConnection(@"Data Source=KARABO_LAPTOP\SQLEXPRESS;Integrated Security=True;Initial Catalog= BioSolveWebClient.database");
            con.Open();
            string UserInDB = "select count(*) from BiosolveUsers where UserName = '"+user.UserName+"'";

            var com = new SqlCommand(UserInDB,con);
            int response = int.Parse(com.ExecuteScalar().ToString());
            con.Close();
            if (response == 1)
            {
                con.Open();
                string PAssCheck = "select Password from BiosolveUsers where UserName ='"+user.UserName+"'";
                var com2 = new SqlCommand(PAssCheck, con);
                string passwordFound = com2.ExecuteScalar().ToString();
                if (passwordFound == user.Password)
                {
                    message = "Password correct";
                }
                else
                {
                    message = "Password incorect";
                }
            }
            else
            {
                message = "User not found in records";
            }
            return message;
        }
    }
}
