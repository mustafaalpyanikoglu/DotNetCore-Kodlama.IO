using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            
            //Müşterileri oluşturuyoruz
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Alp";
            customer1.Surname = "Yanıkoğlu";
            customer1.PhoneNumber = "0555 555 55 53";
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "mustafa";
            customer2.Surname = "Yanıkoğlu";
            customer2.PhoneNumber = "0555 555 55 54";
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "engin";
            customer3.Surname = "demiroğ";
            customer3.PhoneNumber = "0555 555 55 55";
            
            //Müşterileri bir listeye kaydediyoruz
            List<Customer> customers = new List<Customer>();
            customerManager.AddCustomer(customer1, customers);
            customerManager.AddCustomer(customer2, customers);
            customerManager.AddCustomer(customer3, customers);
            
            //Listekedi müşterileri okuyoruz.
            customerManager.ListCustomer(customers);
            
            //Id'si girilen müşteriyi siliyor
            customerManager.DeleteCustomer(customers, 2);
            customerManager.ListCustomer(customers);


        }
    }
}
