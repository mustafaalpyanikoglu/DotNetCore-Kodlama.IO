using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine("number value:{0}",number);
            Console.WriteLine("number value:{0}", RefType(ref number));
            Console.WriteLine("number value:{0}", number);

            int number2 = 10;
            Console.WriteLine("number value:{0}", number2);
            Console.WriteLine("number value:{0}", OutType(out number2));
            Console.WriteLine("number value:{0}", number2);
        }

        //Değerin adresini gönderir bu nedenle işlemler number değişkenine etki eder
        static int RefType(ref int number)
        {
            number = number+1;
            return number;
        }
        //ref type den farklı olarak metoda parametre olarak geçirilmeden önce bir başlangıç değeri
        //almak zorunda değildir
        static int OutType(out int number)
        {
            number = 12;
            number++;
            return number;
        }

    }
}
