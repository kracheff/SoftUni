using System;

class PlayingWithDebugger
{
    static void Main()
    {
        for (int i = 1; i <= 1001; i++)
        {
            if (i % 2 >= 1)
            {
                Console.Write("-" + i + ",");
            }
            else
            {
                Console.Write(i + ",");
            }
        }
    }
}
