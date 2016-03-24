using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write in n: ");
            int number = int.Parse(Console.ReadLine());

            while(number < 0)
            {
                Console.Write("Write in n: ");
                number = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
