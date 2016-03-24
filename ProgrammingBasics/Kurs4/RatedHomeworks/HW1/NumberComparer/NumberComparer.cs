using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write in the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Number a: " + firstNumber + " Number b: " + secondNumber);

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("The greater number is: " + firstNumber);
            }
            else
            {
                Console.WriteLine("The greater number is: " + secondNumber);
            }
        }
    }
}
