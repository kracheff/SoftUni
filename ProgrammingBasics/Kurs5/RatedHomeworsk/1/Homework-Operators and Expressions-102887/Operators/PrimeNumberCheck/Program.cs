using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("Prime?");
            Console.WriteLine("False");
        }
        else
        {
            int primeCount = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    primeCount++;
                }
            }

            bool prime = true;

            if (primeCount > 2)
            {
                prime = false;
            }

            Console.WriteLine("Prime?");
            Console.WriteLine(prime);
        }
    }
}