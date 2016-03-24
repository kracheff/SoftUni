using System;
    class House
{
    static void Main()
    {
        int n = 9; //int.Parse(Console.ReadLine());
        int width = (n * 2) - 1;
        int outerDots = n - 1;
        char dot = '.';

        Console.WriteLine("{0}*{0}", new string(dot, outerDots));

        outerDots--;
        int emptySpace = 1;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string(dot, outerDots),
                new string(' ', emptySpace));
            outerDots--;
            emptySpace += 2;
        }

        for (int i = 0; i < width; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();

        Console.WriteLine("+{0}+", new string('-', width - 2));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', width - 2));
        }

        Console.WriteLine("+{0}+", new string('-', width - 2));
    }
}
