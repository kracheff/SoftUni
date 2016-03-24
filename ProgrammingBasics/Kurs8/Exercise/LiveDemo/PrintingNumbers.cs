using System;
class PrintingNumbers
{


    static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        PrintEvenNumbers(min, max);
    }

    public static void PrintEvenNumbers(int minRange, int maxRange)
    {
        for (int i = minRange; i <= maxRange; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}
