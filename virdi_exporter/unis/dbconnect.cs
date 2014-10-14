using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace unis
{
   public partial class Dbconnect 
    {
        public SqlConnection ShareConnection = new SqlConnection();

        public void Dbconnection(string password, string dbname, string servName, string userName, string table,string feild)
        {
            string connectionString = "Data Source=";
            connectionString += servName + ";";
            if (userName == "") connectionString += "Integrated Security=True;";
            else
            {
                connectionString += "Persist Security Info=True;User ID=" + userName + ";" +
                                    "Password=" + password + ";";
            }

            // TheConnectionString = strConnect;
            var aConnect = new SqlConnection {ConnectionString = connectionString};

            try
            {
                aConnect.Open();
            }
            catch (SqlException)
            {
                aConnect.Close();
                MessageBox.Show(@"failed to find db");
                return;
            }

            aConnect.Close();
            aConnect.ConnectionString += "Initial Catalog=" + dbname;

            ShareConnection.ConnectionString = connectionString;

            try
            {

                
                aConnect.Open();
                    
                 
                var dBtables = new DataTable();
                string sqlString = "Select TOP 1 * from dbo." + table + ";";
                var dbAdapater = new SqlDataAdapter(sqlString, aConnect);
                dbAdapater.Fill(dBtables);
                int i = dBtables.Columns.IndexOf(feild);
                 

                

              //  ShareConnection.Close();



                if (i == -1)
                    //create Exported column coz it was not found
                    MessageBox.Show(feild + @" missing in DB, CREATE?");
            }
            catch (Exception)
            {
                MessageBox.Show(@"failed to connect");
            }
        }
    }
}
