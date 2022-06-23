using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] Names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(Names[0]);
            //Console.WriteLine(Names[1]);
            //Console.WriteLine(Names[2]);
            //Console.WriteLine(Names[3]);

            List<string> Names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            foreach (string name in Names2)
            {
                Console.WriteLine(name);
            }

        }
    }
}
