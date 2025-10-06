using System;

using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

namespace samples
{
    class AdbkGlobal
    {
        static void Main(string[] args)
        {
            // Create a connection to IRIS
            //IRISConnection conn = new IRISConnection();
            IRISConnection conn = new();
            IRIS iris;

            // IRIS server Connection Information
            // Set Server to your IP address and port to IRIS SuperServer port, Log File is optional
            conn.ConnectionString = "Server = localhost; Port=1972; Namespace=USER; Password = SYS; User ID = _SYSTEM;";

            //Open a Connection to IRIS
            conn.Open();

            iris = IRIS.CreateIRIS(conn);

            iris.ClassMethodString("Samples.ADBK", "Init");
            IRISList adbkrecord = (IRISList)iris.GetIRISList("Samples.ADBKD",1);

            Console.WriteLine("Name = " + adbkrecord.Get(2));
            Console.WriteLine("Telno = " + System.Text.Encoding.ASCII.GetString(adbkrecord.GetBytes(4)));
            Console.WriteLine("Prefecture = " + adbkrecord.Get(5));
            Console.WriteLine("Zipcode = " + adbkrecord.Get(3).ToString());
            
            conn.Close();
        }
    }
}
