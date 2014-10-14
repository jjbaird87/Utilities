using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace unis
{
   public partial class Dbconnect 
    {
        public SqlConnection ShareConnection = new SqlConnection();



        public void Dbconnection(string password, string servName, string userName, bool authenticate)
        {
               string  connectionString = "Data Source=";
                connectionString += servName + ";";

                if (authenticate==true) connectionString += "Integrated Security=True;";
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
            aConnect.ConnectionString += "Initial Catalog=Unis";
            connectionString += "Initial Catalog=Unis";
            ShareConnection.ConnectionString = connectionString;

            try
            {


                aConnect.Open();                      
                var dBtables = new DataTable();
                string sqlString = "Select TOP 1 * from dbo.Tenter;";
                var dbAdapater = new SqlDataAdapter(sqlString, aConnect);
                dbAdapater.Fill(dBtables);
                int i = dBtables.Columns.IndexOf("Exported");

                MessageBox.Show("Connection to database was successful", "Connected", MessageBoxButtons.OK);    

                if (i == -1)
                    //create Exported column coz it was not found
                    MessageBox.Show(@" missing in DB, CREATE?", "Exported column is missing in the Tenter table");
            }
            catch (Exception)
            {
                MessageBox.Show(@"failed to connect");
            }
        }
    }
}
