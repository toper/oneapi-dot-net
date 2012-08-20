using System;
using OneApi.Config;
using OneApi.Client.Impl;
using OneApi.Model;

namespace OneApi.Examples.Hlr
{

    public class QueryHLRSyncExample : ExampleBase
	{

        private static string address = "";

        public static void Execute()
		{
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("OneApiExamples.exe.config"));

            Configuration configuration = new Configuration(username, password);    
			SMSClient smsClient = new SMSClient(configuration);

            //Login user
            LoginResponse loginResponse = smsClient.CustomerProfileClient.Login();
            if (loginResponse.Verified == false)
            {
                Console.WriteLine("User is not verified!");
                return;
            }

            Roaming roaming = smsClient.HlrClient.QueryHLRSync(address);
			Console.WriteLine("HLR: " + roaming);
		}
	}

}