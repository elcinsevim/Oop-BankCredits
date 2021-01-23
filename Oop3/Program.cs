using System;
using System.Collections.Generic;
using static Oop3.DatabaseLoggerService;

namespace Oop3
{
    class Program

    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager morgageCreditManager = new MorgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeanApplication(new ArtisanCreditManager(), loggers);
            
            List<ICreditManager> credits = new List<ICreditManager>() { morgageCreditManager, personalFinanceCreditManager, transportCreditManager };
            {
               
            }
        }

    }
}

