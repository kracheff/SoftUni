using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i < num)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(i);
            }
        }
        Console.WriteLine();
    }
}
