using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                if (i < 1001)
                {
                    Console.Write(i * (Math.Pow(-1, i)) + ",");
                }
            else
                {
                    Console.Write(i * (Math.Pow(-1, i)));
                    Console.WriteLine();
                }
            }
        }
    }
}
