using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product customer1 = new Product("Engin Demiroğ","engin@gmail.com","0555 555 55 55");
            Product customer2 = new Product("Kerem Varış","kerem@gmail.com", "0555 555 55 55");
            Product customer3 = new Product("Murat Kurtboğan", "murat@gmail.com", "0555 555 55 55");
            Product[] customers = new Product[] {customer1,customer2,customer3 };
            Console.WriteLine("---FOREACH---");
            foreach (Product customer in customers)
            {
                Console.WriteLine(customer.Name + " : " + customer.Eposta + " : " + customer.PhoneNumber);
            }
            Console.WriteLine("---FOR---");
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(customers[i].Name + " : " + customers[i].Eposta + " : " + customers[i].PhoneNumber);
            }
            Console.WriteLine("---WHILE---");
            int sayac = 0;
            while(sayac<customers.Length)
            {
                Console.WriteLine(customers[sayac].Name + " : " + customers[sayac].Eposta + " : " + customers[sayac].PhoneNumber);
                sayac++;
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public string Eposta { get; set; }
        public string PhoneNumber { get; set; }

        public Product(string name,string ePosta,string phoneNumber)
        {
            this.Name = name;
            this.Eposta = ePosta;
            this.PhoneNumber = phoneNumber;
        }
    }
}
