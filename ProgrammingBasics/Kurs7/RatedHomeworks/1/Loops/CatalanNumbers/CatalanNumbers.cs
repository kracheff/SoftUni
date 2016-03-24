using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            double numberN = double.Parse(Console.ReadLine());
            double NN = 2 * numberN;
            double N1 = 1 + numberN;
            double NNFactorial = 1;
            double N1Factorial = 1;
            double numberNFactorial = 1;
            double sum = 0;

            for (int i = 1; i <= NN; i++)
            {
                NNFactorial *= i;
            }
            for (int j = 1; j <= N1; j++)
            {
                N1Factorial *= j;
            }
            for (int k = 1; k <= numberN; k++)
            {
                numberNFactorial *= k;
            }
            sum = NNFactorial / (N1Factorial * numberNFactorial);

            Console.WriteLine(sum);
        }
    }
}
