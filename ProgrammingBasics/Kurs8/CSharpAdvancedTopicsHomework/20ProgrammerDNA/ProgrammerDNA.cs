using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main(string[] args)
        {
            int n = 10; // int.Parse(Console.ReadLine());
            char letter = 'F'; // char.Parse(Console.ReadLine());


            int numberOfDots = 3;
            int numberOfChars = 1;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', numberOfDots - counter),
                        new string(letter, numberOfChars));
                    numberOfDots--;
                    counter++;
                }
            }
        }
    }
}
