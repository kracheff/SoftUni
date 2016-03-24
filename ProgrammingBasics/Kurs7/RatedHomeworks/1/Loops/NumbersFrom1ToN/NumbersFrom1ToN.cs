using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Integer:");
            int insertnumber = int.Parse(Console.ReadLine());
            int startnumber = 1;

            while (startnumber<=insertnumber)
            {
                Console.Write("{0} ", startnumber);
                startnumber++;
            }
            Console.WriteLine();
        }
    }
}
