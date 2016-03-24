using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {   
            Console.Write("Write in n: ");
            int lenght = int.Parse(Console.ReadLine());

            while(lenght < 0)
            {
                Console.Write("n must be bigger then 0; \nWrite in n: ");
                lenght = int.Parse(Console.ReadLine());
            }

            int result = 0;

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Write in number: ");
                int number = int.Parse(Console.ReadLine());

                result += number;
            }

            Console.WriteLine("Result: " + result);

        }
    }
}
