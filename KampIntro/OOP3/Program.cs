using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager cunsomerLoanManager = new CunsomerLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager homeLoanManager = new HomeLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>();
            loggerServices.Add(fileLoggerService);
            loggerServices.Add(databaseLoggerService);

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(cunsomerLoanManager,loggerServices);
            
            Console.WriteLine("----------------------------------------");
            applicationManager.MakeApplication(new BusinessLoanManager(),loggerServices);
            
            Console.WriteLine("----------------------------------------");
            applicationManager.MakeApplication(vehicleLoanManager,new List<ILoggerService>() {new SmsLoggerService(),databaseLoggerService });


            
            List<ICreditManager> creditManagers = new List<ICreditManager>() { };
            creditManagers.Add(cunsomerLoanManager);
            creditManagers.Add(homeLoanManager);
            //applicationManager.MakeLoanPreInformation(creditManagers);


        }
    }
}
