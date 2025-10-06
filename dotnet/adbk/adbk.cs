using System;

using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

namespace samples
{
    class Adbk
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
            IRISObject adbk = (IRISObject)iris.ClassMethodObject("Samples.ADBK", "%OpenId",1);

            Console.WriteLine("Name = " + adbk.Get("Name"));
            Console.WriteLine("Telno = " + adbk.Get("Telno"));
            Console.WriteLine("Prefecture = " + adbk.Get("Prefecture"));
            Console.WriteLine("Zipcode = " + adbk.Get("Zipcode").ToString());
            

            conn.Close();
        }
    }
}
