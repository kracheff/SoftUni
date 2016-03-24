using System;
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = firstInt; i <= secondInt; i++)
        {
            if (i % 5 == 0)
            {
                p += 1;
            }
        }
        Console.WriteLine(p);
    }
}
