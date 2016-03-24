using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNumbers
{
    class MatrixNumbers
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("{0} ", i);
                for (int j = 1+i ; j <= N+i-1; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
