using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFiveNumbers
{
    class SunFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write in number a: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in number b: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in number c: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in number d: ");
            double forthNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in number e: ");
            double fifthNumber = double.Parse(Console.ReadLine());

            double Sum;

            Sum = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;

            Console.Clear();

            Console.WriteLine("First number: " + firstNumber +
                "\nSecond number: " + secondNumber +
                "\nThird number: " + thirdNumber +
                "\nForth number: " + forthNumber +
                "\nFifth number: " + fifthNumber +
                "\nSum of numbers: " + Sum);
        }
    }
}
