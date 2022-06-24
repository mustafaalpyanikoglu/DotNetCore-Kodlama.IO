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
             
            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(cunsomerLoanManager);
            //applicationManager.MakeApplication(vehicleLoanManager);
            //applicationManager.MakeApplication(homeLoanManager);

            List<ICreditManager> creditManagers = new List<ICreditManager>() { };
            creditManagers.Add(cunsomerLoanManager);
            creditManagers.Add(homeLoanManager);
            applicationManager.MakeLoanPreInformation(creditManagers);


        }
    }
}
