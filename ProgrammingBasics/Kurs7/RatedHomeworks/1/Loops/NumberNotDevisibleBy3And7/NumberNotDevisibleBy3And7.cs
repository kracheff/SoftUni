using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNotDevisibleBy3And7
{
    class NumberNotDevisibleBy3And7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Integer:");
            int insertnumber = int.Parse(Console.ReadLine());
            int startinteger = 1;

            while (startinteger<=insertnumber)
            {
                if (startinteger% 3 != 0 && startinteger%7!=0)
                {
                    Console.Write("{0} ", startinteger);
                }
                startinteger++;
            }
            Console.WriteLine();
        }
    }
}
