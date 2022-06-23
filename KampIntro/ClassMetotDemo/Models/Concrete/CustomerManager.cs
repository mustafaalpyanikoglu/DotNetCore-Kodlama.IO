using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public List<Customer> AddCustomer(Customer customer,List<Customer> customers)
        {
            customers.Add(customer);
            return customers;
        }
        public void ListCustomer(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.PhoneNumber);
                Console.WriteLine("------------------------");
            }
        }
        public List<Customer> DeleteCustomer(List<Customer> customers,int Id)
        {
            foreach (Customer customer in customers)
            {
                if(customer.Id==Id)
                {
                    customers.Remove(customer);
                    break;
                }
            }
            return customers;
        }
    }
}
