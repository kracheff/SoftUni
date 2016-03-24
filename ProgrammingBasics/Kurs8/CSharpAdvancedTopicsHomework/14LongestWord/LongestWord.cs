using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14LongestWord
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int longest = int.MinValue;
            string text = string.Empty;

            string[] splitInput = input.Split(new char[] { ',', '.', ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in splitInput)
            {
                if (item.Length > longest)
                {
                    longest = item.Length;
                    text = item;
                }
            }

            Console.WriteLine(text);
        }
    }
}
