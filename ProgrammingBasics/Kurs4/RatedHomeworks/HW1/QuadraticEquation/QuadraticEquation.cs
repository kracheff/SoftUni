using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Write in a: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in b: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Write in c: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double x1 = (-secondNumber - Math.Sqrt(thirdNumber)) / (2 * firstNumber);
            double x2 = (-secondNumber + Math.Sqrt(thirdNumber)) / (2 * firstNumber);

            Console.WriteLine("x1: {0} \nx2: {1}", x1,x2);



        }
    }
}
