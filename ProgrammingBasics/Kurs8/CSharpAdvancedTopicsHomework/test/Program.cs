using System;

class ProgrammerDNA
{
    static void Main()
    {
        char dots = '.';
        char chars = '*';
        int length = 7;
        int width = 7;
        int numberOfDots = 3;
        int numberOfChars = 1;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string(dots, numberOfDots),
                new string(chars, numberOfChars));

            if (numberOfChars == 1)
            {
                numberOfChars += 2;
                numberOfDots--;
                continue;
            }
            if (numberOfChars == 5)
            {
                numberOfChars -= 2;
                numberOfDots++;
                continue;
            }
        }

    }
}
