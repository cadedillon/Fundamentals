using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap
{
    public class IntegerSwap
    {
        static void Main(string[] args)
        {
            int a = 200;
            int b = 100;

            Console.WriteLine($"{a}, {b} <> {IntSwap(a, b)}");
        }

        public static string IntSwap(int a, int b)
        {
            

            Console.WriteLine($"The starting value of a is : {a}");
            Console.WriteLine($"The starting value of b is: {b}");

            a ^= b;
            b = a ^ b;
            a ^= b;

            Console.WriteLine($"The final value of a is: {a}");
            Console.WriteLine($"The final value of b is: {b}");

            return ($"{a}, {b}");
        }
    }
}
