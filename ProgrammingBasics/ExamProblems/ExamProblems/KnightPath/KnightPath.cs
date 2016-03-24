using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KnightPath
{
    static void Main()
    {
        int[] chessBoard = new int[8];
        chessBoard[0] = 1;

        int currentPosX = 0;
        int currentPosY = 0;
        int numberOfPos = 0;
        int firstDirectionX = 0;
        int firstDirectionY = 0;
        int secondDirectionX = 0;
        int secondDirectionY = 0;


        string command = "";

        while (command != "stop")
        {
            command = Console.ReadLine();

            if (command == "stop")
            {
                continue;
            }
            string[] splitCommands = command.Split(' ');

            string firstDirection = splitCommands[0];
            string secondDirection = splitCommands[1];

            // FIRST Direction

            numberOfPos = 2;

            switch (firstDirection)
            {
                case "left": firstDirectionX = 2; break;

                case "right": firstDirectionX = -2; break;

                case "up": firstDirectionY = -2; break;

                case "down": firstDirectionY = 2; break;

                default: break;
            }

            // SECOND Direction

            numberOfPos = 1;

            switch (secondDirection)
            {
                case "left": secondDirectionX = 1; break;

                case "right": secondDirectionX = -1; break;

                case "up": secondDirectionY = -1; break;

                case "down": secondDirectionY = 1; break;

                default: break;
            }

            if (currentPosX + firstDirectionX + secondDirectionX < 7 ||
                currentPosX + firstDirectionX + secondDirectionX > 0 ||
                currentPosY + firstDirectionY + secondDirectionY < 7 ||
                currentPosY + firstDirectionY + secondDirectionY > 0)
            {
                currentPosX += firstDirectionX + secondDirectionX;
                currentPosY += firstDirectionY + secondDirectionY;
            }
            chessBoard[currentPosY] ^= (1 << currentPosX);
        }

        for (int i = 0; i < 8; i++)
        {
            //if (chessBoard[i] != 0)
            //{
            //    Console.WriteLine(chessBoard[i]);
            //}
            Console.WriteLine(Convert.ToString(chessBoard[i], 2).PadLeft(8, '0'));
        }
    }
}