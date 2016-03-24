using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrimeChecker
{
    class PrimeChecker
    {
        static void IsPrime (long n)
        {
            bool nIsPrime = true;
            double nSqrt = Math.Sqrt(n);
            int counter = 0;

            for (int i = 1; i <= nSqrt; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }
            if (counter > 1)
            {
                nIsPrime = false;
            }
            Console.WriteLine(nIsPrime);
        }
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            IsPrime(input);
        }
    }
}
