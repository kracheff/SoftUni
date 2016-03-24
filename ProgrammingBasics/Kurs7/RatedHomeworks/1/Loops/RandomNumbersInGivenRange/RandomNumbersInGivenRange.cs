using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minnumber = int.Parse(Console.ReadLine());
            int maxnumber = int.Parse(Console.ReadLine());
            if (minnumber <= maxnumber)
            {
                Random random = new Random();
                for (int index = 0; index < count; index++)
                {
                    Console.Write("{0} ", random.Next(minnumber, maxnumber + 1));
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}
