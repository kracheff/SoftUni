using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateROW
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double factorial = 1;
            double power = x;
            for (int count = 1; count <= n; count++)
            {
                factorial *= count;
                sum += factorial / x;
                Console.WriteLine(sum);
                x *= power;
            }
            Console.WriteLine("{0 :F5}", sum);
        }
    }
}
