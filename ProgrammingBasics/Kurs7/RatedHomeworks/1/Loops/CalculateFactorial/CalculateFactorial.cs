using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorial
{
    class CalculateFactorial
    {
        static void Main()
        {
            double Nnumber = double.Parse(Console.ReadLine());
            double Knumber = double.Parse(Console.ReadLine());
            double sumN = 1;
            double sumK = 1;

            for (int i = 1; i <= Nnumber; i++)
            {
                sumN *= i;
            }
            for (int j = 1; j <= Knumber; j++)
            {
                sumK *= j;
            }
            Console.WriteLine("{0}", sumN/sumK);
        }
    }
}
