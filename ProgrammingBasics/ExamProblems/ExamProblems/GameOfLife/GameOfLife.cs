using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameOfLife
{
    static void Main()
    {
        // create the initial matrix

        int[,] mainMatrix = new int[10, 10];

        // create the new matrix

        int[,] newMatrix = new int[10, 10];

        // read the input from the console

        int aliveCellsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < aliveCellsCount; i++)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            mainMatrix[X, 9 - Y] = 1;
        }

        int counter = 0;

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {

                for (int i = (x - 1 < 0 ? 0 : x - 1); i <= (x + 1 > 9 ? 9 : x + 1); i++)
                {
                    for (int j = y - 1 < 0 ? 0 : y - 1; j <= (y + 1 > 9 ? 9 : y + 1); j++)
                    {
                        if (mainMatrix[i, j] == 1)
                        {
                            counter++;
                        }
                    }
                }

                if (mainMatrix[x, y] == 0)
                {
                    if (counter == 3)
                    {
                        newMatrix[x, y] = 1;
                    }
                }
                if (mainMatrix[x, y] == 1)
                {
                    newMatrix[x, y] = 1;
                    if ((counter - 1) < 2 || (counter - 1) > 3)
                    {
                        newMatrix[x, y] = 0;
                    }
                }
                counter = 0;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(newMatrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}
