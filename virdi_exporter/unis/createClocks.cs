using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace unis
{

   
    class CreateClocks : Dbconnect

       {

        public void clocks(DataGridView dgv)
        {
            string datFile = @"c:\older\clocks2.dat";
   
            var f = new FileStream(datFile, FileMode.Create, FileAccess.ReadWrite);
            var connect = new SqlConnection();
            var datInfo = new DataTable();
            var sqlString = string.Format("Select C_Unique,C_Date,C_Time,L_TID from dbo.tEnter;");
            var dbAdapater = new SqlDataAdapter(sqlString ,@"Data Source=ANVJHB-PC\DEV_SQLEXPRESS;Initial Catalog=UNIS;Persist Security Info=True;User ID=jj;Password=evolution");
            dbAdapater.Fill(datInfo);
            var w = new StreamWriter(f);

            foreach (DataRow row in datInfo.Rows)
            {
                //employee number
                var employee = row["C_Unique"].ToString();
                employee = employee.PadLeft(8, '0');

                //date
                var dt =  row["C_Date"];

                //time
                var dtTime =  row["C_Time"];
              

                //direction
                string direction ;

                //clock
                var clock = row["L_TID"].ToString();
                clock = clock.PadLeft(3, '0');


                if(clock == "002") ;
                {
                    direction = "I";
                }
           if(clock != "002")
                {
                    direction = "O";
                }
          

              //fix the save and load first then we can write according to the saved settings
                var datafileRow = String.Format("{0} {1} {2} {3} {4}", employee, dt/*.ToString("dd-MM-yyyy")*/,dtTime/*.ToString("HH/MM")*/,direction, clock);

                w.WriteLine(datafileRow);

            }
            w.Close();
        }
       }
}
