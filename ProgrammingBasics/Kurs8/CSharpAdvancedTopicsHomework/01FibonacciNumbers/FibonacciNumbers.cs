using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FibonacciNumbers
{
    class FibonacciNumbers
    {

        static int Fib (int n)
        {
            int sum = 0;
            int firstNumber = 0;
            int secondNumber = 1;


            for (int i = 0; i < n; i++)
            {
                sum = secondNumber + firstNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            Console.WriteLine(sum);
            return sum;
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Fib(input);
        }
    }
}
