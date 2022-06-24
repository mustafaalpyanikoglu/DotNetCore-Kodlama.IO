using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (IWorker worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (IEat eat in eats)
            {
                eat.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat manager.");
        }
        public void Work()
        {
            Console.WriteLine("Work manager.");
        }
        public void GetSalary()
        {
            Console.WriteLine("GetSalary manager.");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat Worker.");
        }

        public void GetSalary()
        {
            Console.WriteLine("GetSalary Worker.");
        }

        public void Work()
        {
            Console.WriteLine("Work Worker.");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work Robot.");
        }
    }
}

