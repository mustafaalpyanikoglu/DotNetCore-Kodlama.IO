using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Individual--Gerçek müşteri
    class Individual:Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
