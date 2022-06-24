using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id = 1, FirstName = "Engin" });
            //personManager.Add(new Student { Id = 1, FirstName = "Alp" });

            //Demo()
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            //Şirketteki tüm veritabanlarına aynı datayı atmak için böyle bir yöntem uygulayabiliriz.
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }

        }
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
