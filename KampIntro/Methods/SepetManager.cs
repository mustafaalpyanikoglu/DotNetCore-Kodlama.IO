using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string comment , double price ,int StockQuantity)
        {
            Console.WriteLine("Sepete eklendi : " + productName);
        }
    }
}
