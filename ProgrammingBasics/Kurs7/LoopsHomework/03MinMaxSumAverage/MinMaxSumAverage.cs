using System;
class MinMaxSumAverage
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < numberOfInputs; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\naverage = {3:F}", 
            min, max, sum, (double)sum / numberOfInputs);
    }
}
