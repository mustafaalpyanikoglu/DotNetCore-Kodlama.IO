using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Comment = "Amasya elması.";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Comment = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Comment);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------Metotlar---------");

            SepetManager sepetManager = new SepetManager();
            //encapsulation
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            Console.WriteLine("------------------");
            sepetManager.Add2("Armut" , "Yeşil armut" , 12 ,9);
            sepetManager.Add2("Elma", "Yeşil elma", 13 ,3);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 14 ,5);

        }
    }
}
