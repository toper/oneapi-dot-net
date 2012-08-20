﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OneApi.Config;
using OneApi.Client.Impl;
using OneApi.Model;
using org.infobip.oneapi.model;

namespace OneApi.Examples.CustomerProfiles
{
    class GetAccountBalanceExample : ExampleBase
    {
        public static void Execute()
        {
            Configuration configuration = new Configuration(username, password);    
            SMSClient smsClient = new SMSClient(configuration);

            //Login user
            LoginResponse loginResponse = smsClient.CustomerProfileClient.Login();
            if (loginResponse.Verified == false)
            {
                Console.WriteLine("User is not verified!");
                return;
            }

            AccountBalance accountBalance = smsClient.CustomerProfileClient.GetAccountBalance();
            Console.WriteLine("Account Balance: " + accountBalance);   
            Console.WriteLine();
        }
    }
}
