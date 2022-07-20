using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //FourTransactions fourTransactions = new FourTransactions(2, 3);
            //Console.WriteLine(fourTransactions.Sum2());
            //Console.WriteLine(fourTransactions.Sum(3, 4));

            var type = typeof(FourTransactions);
            //FourTransactions fourTransactions = (FourTransactions)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(fourTransactions.Sum(4, 5));
            //Console.WriteLine(fourTransactions.Sum2());

            var instance = Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Metod adı: {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute name: {0}",attribute.GetType().Name);
                }
            }
        }

        class FourTransactions
        {
            private int _number1;

            public FourTransactions(int number1,int number2)
            {
                _number1 = number1;
                _number2 = number2;
            }

            private int _number2;

            public int Sum(int number1,int number2)
            {
                return number1 + number2;
            }

            public int Multiply(int number1,int number2)
            {
                return number1 * number2;
            }

            public int Sum2()
            {
                return _number1 + _number2;
            }
            [MethodName("Carpma")]
            public int Multiply2()
            {
                return _number1 * _number2;
            }
        }

        public class MethodNameAttribute:Attribute
        {
            public MethodNameAttribute(string name)
            {

            }
        }
    }
}
