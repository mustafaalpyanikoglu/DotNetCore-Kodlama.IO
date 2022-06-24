using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
        }

        public void MakeLoanPreInformation(List<ICreditManager> creditManagers)
        {
            foreach (ICreditManager creditManager in creditManagers)
            {
                creditManager.Calculate();
            }
            
        }
    }
}
