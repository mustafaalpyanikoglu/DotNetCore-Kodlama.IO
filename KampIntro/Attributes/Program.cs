using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Alp",
                LastName = "Yanıkoğlu",
                Age = "21"
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
        [ToTable("Customers")]
        [ToTable("tblCustomers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public string Age { get; set; }
        }
        
        class CustomerDal
        {
            [Obsolete("Don't use Add, instead use AddNew Method")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!",customer.Id,customer.FirstName,customer.LastName,customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }

        [AttributeUsage(AttributeTargets.Property)]
        class RequiredPropertyAttribute:Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
        class ToTableAttribute : Attribute
        {
            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                this._tableName = tableName;
            }
        }
    }
}
