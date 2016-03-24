using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SummerTime
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}",
            new string(' ', (2 * input - input - 1) / 2),
            new string('*', input + 1));

        for (int i = 0; i < (input + 1) / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string(' ', (2 * input - input - 1) / 2),
                new string(' ', input - 1));
        }

        for (int i = 0, j = (2 * input - 3 - input) / 2, k = input + 1; i < (input - 3) / 2; i++, j--, k+=2)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string(' ', j),
                new string(' ', k));
        }

        for (int i = 0; i < 2 * input + 1; i++)
        {
            if (i < input)
            {
                Console.WriteLine("*{0}*",
                    new string('.', 2 * input - 2));

            }
            else if (i == 2 * input)
            {
                Console.WriteLine("*{0}*",
                    new string('*', 2 * input - 2));

            }
            else
            {
                Console.WriteLine("*{0}*",
                    new string('@', 2 * input - 2));

            }
        }
    }
}
