using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSomething();

            int first = 10;
            int second = 2;
            int result = Sum(first, second);
            Console.WriteLine("The sum of {0} and {1} is: {2}", first, second, result);

            string sValue;
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine("Returning multiple values from a method: {0} and {1}", first.ToString(), sValue);

            // ref requires that we initialize the variable we want to assign to first
            string sValue2 = "";
            ReturnMultiRef(ref first, ref sValue2);
            Console.WriteLine("Returning multiple values from a method: {0} and {1}", first.ToString(), sValue2);
        }

        static void PrintSomething()
        {
            Console.WriteLine("PrintSomething() method is called.");
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 25;
            s = "using ref";
        }
    }
}
