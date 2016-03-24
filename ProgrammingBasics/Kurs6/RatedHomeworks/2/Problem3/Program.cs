using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capital Letters only:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "A": Console.WriteLine("yes"); break;
                case "2": Console.WriteLine("yes"); break;
                case "3": Console.WriteLine("yes"); break;
                case "4": Console.WriteLine("yes"); break;
                case "5": Console.WriteLine("yes"); break;
                case "6": Console.WriteLine("yes"); break;
                case "7": Console.WriteLine("yes"); break;
                case "8": Console.WriteLine("yes"); break;
                case "9": Console.WriteLine("yes"); break;
                case "10": Console.WriteLine("yes"); break;
                case "J": Console.WriteLine("yes"); break;
                case "Q": Console.WriteLine("yes"); break;
                case "K": Console.WriteLine("yes"); break;
                default: Console.WriteLine("invalid card"); break;

            }

        }
    }
}
