using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            char kupa = '\u2665';
            char pika = '\u2660';
            char karo = '\u2666';
            char spatiq = '\u2663';

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}" , i , spatiq , karo , kupa , pika);
            }
            Console.WriteLine("J{0} J{1} J{2} J{3}", spatiq, karo, kupa, pika);
            Console.WriteLine("Q{0} Q{1} Q{2} Q{3}", spatiq, karo, kupa, pika);
            Console.WriteLine("K{0} K{1} K{2} K{3}", spatiq, karo, kupa, pika);
            Console.WriteLine("A{0} A{1} A{2} A{3}", spatiq, karo, kupa, pika);
        }
    }
}
