using System;
class PrintAsciiTable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            char ascii = (char)i;
            Console.WriteLine(i + " - " + ascii);
        }
    }
}

