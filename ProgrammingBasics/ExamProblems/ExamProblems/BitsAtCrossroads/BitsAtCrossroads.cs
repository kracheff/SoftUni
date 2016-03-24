using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsAtCrossroads
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 8;
        int[] board = new int[n];
        int crossroads = 0;

        string input = Console.ReadLine();

        while (input != "end")
        {
            crossroads++;
            int initialX = int.Parse(input.Split(' ')[1]);// 5; // bit position ... second integer input[1]
            int initialY = int.Parse(input.Split(' ')[0]);// 2;

            int x = initialX;
            int y = initialY;

            board[y] |= 1 << x;

            while (x < n - 1 && y > 0)
            {
                x += 1;
                y -= 1;
                board[y] |= (1 << x);
            }

            x = initialX;
            y = initialY;

            while (x > 0 && y < n - 1)
            {
                x -= 1;
                y += 1;
                board[y] |= (1 << x);
            }

            x = initialX;
            y = initialY;

            while (x < n - 1 && y < n - 1)
            {
                x += 1;
                y += 1;
                board[y] |= (1 << x);
            }

            x = initialX;
            y = initialY;

            while (x > 0 && y > 0)
            {
                x -= 1;
                y -= 1;
                board[y] |= (1 << x);
            }

            input = Console.ReadLine();
        }


        // count the crossroads
        int counter = 0;

        for (int X = 0; X < n; X++)
        {
            for (int Y = 0; Y < n; Y++)
            {
                if (((board[X] >> Y) & 1) == 1)
                {
                    int minX = Math.Max(X - 1, 0);
                    int maxX = Math.Min(X + 1, n - 1);
                    int minY = Math.Max(Y - 1, 0);
                    int maxY = Math.Min(Y + 1, n - 1);

                    for (int i = minX; i <= maxX; i++)
                    {
                        for (int j = minY; j <= maxY; j++)
                        {
                            if (((board[i] >> j) & 1) == 1)
                            {
                                counter++;
                            }
                            if (counter > 4)
                            {
                                crossroads++;
                            }
                            counter = 0;
                        }
                    }
                }
            }
        }

        // print the output
        foreach (var el in board)
        {
            Console.WriteLine(el);
        }
        Console.WriteLine(crossroads);
    }
}