using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("The Biggest Number is {0}", a);
            }
            else if (c > a && c > b)
            {

                Console.WriteLine("The Biggest Number is {0}", b);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The Biggest Number is {0}", c);

            }
        }
    }
}
