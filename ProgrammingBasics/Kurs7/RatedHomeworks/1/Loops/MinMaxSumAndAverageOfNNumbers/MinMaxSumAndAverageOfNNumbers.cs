using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 0;
            double averageSum;
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int index = 0; index < num; index++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;
                if (newNumber > maxNumber)
                {
                    maxNumber = newNumber;
                }
                if (newNumber < minNumber)
                {
                    minNumber = newNumber;
                }
            }

            averageSum = sum / num;
            Console.WriteLine("min = {0}", minNumber);
            Console.WriteLine("max = {0}", maxNumber);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0 :F2} ", averageSum);
        }
    }
}
