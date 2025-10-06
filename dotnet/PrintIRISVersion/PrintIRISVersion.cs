using System;
using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

namespace samples
{
    class PrintIRISVersion
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

            string ReturnValue = iris.ClassMethodString("%SYSTEM.Version", "GetVersion");

            Console.WriteLine("ReturnValue = " + ReturnValue);
            
            string curDirectory = System.Environment.CurrentDirectory;
            
            string delim = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
              delim = "¥";    
            }
            else {
              delim = "/";    
            }
            
            string substring = delim + "dotnet" + delim;
            
            string fileName = curDirectory.Split(substring)[0] + delim + "src" + delim + "Samples" + delim + "ADBK.cls";
            
            Console.WriteLine("fileName = " + fileName);
            var status = iris.ClassMethodObject("%SYSTEM.OBJ", "Import", fileName, "ck");
            Console.WriteLine("status = " + status);

            conn.Close();
        }
    }
}
