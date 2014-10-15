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
                MessageBox.Show(@"failed to connect to Database");
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

                //create exported if not found
                if (i == -1)                 
                {
                    string command = "IF NOT  EXISTS(SELECT * FROM sys.columns WHERE Name = N'Exported' and Object_ID = Object_ID(N'[dbo].[tEnter]')) BEGIN ALTER TABLE [dbo].[tEnter] ADD Exported varchar(1) END ";
                    SqlCommand addColumn = new SqlCommand(command, aConnect);
                    addColumn.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(@"failed to connect");
                //just in case
                string command = "IF NOT  EXISTS(SELECT * FROM sys.columns WHERE Name = N'Exported' and Object_ID = Object_ID(N'[dbo].[tEnter]')) BEGIN ALTER TABLE [dbo].[tEnter] ADD Exported varchar(1) END ";
                SqlCommand addColumn = new SqlCommand(command, aConnect);
                addColumn.ExecuteNonQuery();
            }
        }
    }
}
