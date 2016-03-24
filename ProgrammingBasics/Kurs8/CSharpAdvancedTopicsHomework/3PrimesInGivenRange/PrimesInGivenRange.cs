using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                double numSqrt = Math.Sqrt(i);
                int counter = 0;

                for (int j = 1; j <= numSqrt; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 1 && i != 1)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primeNumbers = FindPrimesInRange(start, end);

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (i == primeNumbers.Count - 1) // ignore the last comma
                {
                    Console.Write("{0}", primeNumbers[i]);
                }
                else
                {
                    Console.Write("{0}, ", primeNumbers[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
