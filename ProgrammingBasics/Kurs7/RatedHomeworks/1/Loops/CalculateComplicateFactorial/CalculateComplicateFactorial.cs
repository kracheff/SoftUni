using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateComplicateFactorial
{
    class CalculateComplicateFactorial
    {
        static void Main()
        {
            double numberN = double.Parse(Console.ReadLine());
            double numberK = double.Parse(Console.ReadLine());
            double numN = 1;
            double numK = 1;
            double DPart = 1;
            double UpThing = 0;
            double DownPart = numberN - numberK;
            double DownThing = 0;

            for (int i = 1; i <= numberN; i++)
            {
                numN *= i;
            }
            for (int j = 1; j <= numberK; j++)
            {
                numK *= j;
            }
            for (int k = 1; k <= DownPart; k++)
            {
                DPart *= k;
            }
            UpThing = numN;
            DownThing = numK * DPart;
            Console.WriteLine("{0}" , UpThing/DownThing);
        }
    }
}
