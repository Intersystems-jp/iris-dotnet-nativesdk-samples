using System;
using InterSystems.Data.IRISClient;

using InterSystems.Data.IRISClient.ADO;

namespace samples
{
    class AdbkAdo
    {
        static void Main(string[] args)
        {
            // Create a connection to IRIS
            //IRISConnection conn = new IRISConnection();
            IRISConnection conn = new()
            {
                // IRIS server Connection Information
                // Set Server to your IP address and port to IRIS SuperServer port, Log File is optional
                ConnectionString = "Server = localhost; Port=1972; Namespace=USER; Password = SYS; User ID = _SYSTEM;"
            };

            //Open a Connection to IRIS
            conn.Open();

            String sqltext = "Select Name, Telno, Prefecture, Zipcode from Samples.ADBK";
            
            IRISCommand sqlcommand = new(sqltext, conn);

            IRISDataReader reader = sqlcommand.ExecuteReader(); 
            while (reader.Read())
            {
                
              Console.WriteLine("Name = " + reader.GetValue(0));
              Console.WriteLine("Telno = " + reader.GetValue(1));;
              Console.WriteLine("Prefecture = " + reader.GetValue(2));;
              Console.WriteLine("Zipcode = " + reader.GetValue(3));

            }
            
            conn.Close();
        }
    }
}
