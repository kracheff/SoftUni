using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] allInputs = new string[n];
            string lastString = string.Empty;
            int longestSequence = 1;
            int currentSequence = 1;
            string longestString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                allInputs[i] = input;

                if (input == lastString)
                {
                    currentSequence++;
                    lastString = input;
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        longestString = input;
                    }
                }
                else
                {
                    currentSequence = 1;
                    lastString = input;
                }
            }
            if (longestSequence == 1)
            {
                longestString = allInputs[0];
            }

            Console.WriteLine();
            Console.WriteLine(longestSequence);
            for (int i = 0; i < longestSequence; i++)
            {
                Console.WriteLine(longestString);
            }
        }
    }
}
