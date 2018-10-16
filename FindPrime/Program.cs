using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindPrime.IsPrime(7));
        }
    }

    public class FindPrime
    {
        public static bool IsPrime(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
