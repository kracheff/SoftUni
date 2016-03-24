using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program // JUST TESTING STUFF. IGNORE IT, PLEASE.
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            string test = string.Empty;

            foreach (var item in splitInput)
            {
                test += item;
            }
            Console.WriteLine(test);
        }
    }
}
