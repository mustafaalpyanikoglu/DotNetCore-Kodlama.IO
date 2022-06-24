using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            IPersonManager employedManager = new EmployedManager();
            employedManager.Add();
            employedManager.Update();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployedManager());
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation.
        void Add();
        void Update();
    }

    // Inherits - class --------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployedManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
