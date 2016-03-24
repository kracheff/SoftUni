using System;
using System.Collections.Generic;



class Min_Max_SumAndAverageOfN_Numbers
{


    static void Main(string[] args)
    {
        checked
        {
            Console.Write("Enter n = ");
            
            int countN = int.Parse(Console.ReadLine());
            if (countN < 1)
            {
                Console.WriteLine("Error: Invalid Number !");
            }
            else
            {
                
                List<int> numbers = new List<int>(countN);
                for (int i = 0; i < countN; i++)
                {
                    Console.Write("Enter number = ");
                   
                    numbers.Add(int.Parse(Console.ReadLine()));
                }

                double numMin = double.MaxValue;
                double numMax = double.MinValue;
                double sumOfAllNumbers = 0;
                foreach (var number in numbers)
                {
                    numMin = Math.Min(numMin, number);
                    numMax = Math.Max(numMax, number);
                    sumOfAllNumbers += number;
                }
                double averageNumbers = sumOfAllNumbers / countN;
                
             
                Console.WriteLine("min = {0}", numMin, numMax);
                Console.WriteLine("max = {0}",numMax);
                Console.WriteLine("sum = {0}", sumOfAllNumbers);
                Console.WriteLine("average = {0:0.00}",averageNumbers);
            }
            
        }
    }
}

