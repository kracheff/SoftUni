using System;
class MagicWand
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        // first row
        string firstRow = new string('.', n * 3 / 2 + 1);
        Console.WriteLine(firstRow + '*' + firstRow);

        // first loop
        int firstCounter = n * 3 / 2;
        for (int i = 1; i <= n; i += 2)
        {
            string firstDotsBlue = new string('.', firstCounter);
            string secondDotsBlue = new string('.', i);
            Console.WriteLine(firstDotsBlue + '*' + secondDotsBlue + '*' + firstDotsBlue);
            firstCounter -= 1;
        }

        // independent row
        string greenAst = new string('*', n);
        string greenDots = new string('.', n + 2);
        Console.WriteLine(greenAst + greenDots + greenAst);

        // second loop
        int secondCounter = n * 3 - 2;
        int dotsCounter = 1;
        for (int j = secondCounter; j >= 2 * n + 1; j -= 2)
        {
            string firstDotsYellow = new string('.', dotsCounter);
            string secondDotsYellow = new string('.', j);
            Console.WriteLine(firstDotsYellow + '*' + secondDotsYellow + '*' + firstDotsYellow);
            dotsCounter += 1;
        }

        // grey part
        int zeros = (n - 3) / 2;
        int threes = 0;
        for (int i = 0; i < (n-1)/2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', zeros), new string('.', (n - 1) / 2), new string('.', threes),
                new string('.', n));
            zeros--;
            threes++;
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', (n+1)/2), new string('.', (n-1)/2), new string('.', n));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string ('.', n));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n+2));
    }
}
