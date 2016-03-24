using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LightTheTorches
{
    static void Main()
    {
        int numberOfRooms = int.Parse(Console.ReadLine());
        string darkOrLight = Console.ReadLine();

        string[] roomsState = new string[numberOfRooms];

        for (int i = 0, count = 0; i < numberOfRooms; i++, count++)
        {
            if (count > darkOrLight.Length - 1)
            {
                count = 0;
            }
            roomsState[i] = darkOrLight[count].ToString();
        }

        int startingPoint = numberOfRooms / 2;
        int lastRoomIndex = startingPoint;
        int nextRoomIndex = 0;
        string command = string.Empty;

        // start receiving commands

        while (command != "END")
        {
            command = Console.ReadLine();

            if (command == "END")
            {
                break;
            }

            string[] splitCommand = command.Split(' ');
            string direction = splitCommand[0];
            int movesInDirection = int.Parse(splitCommand[1]) + 1;

            if (direction == "LEFT")
            {
                if (lastRoomIndex - movesInDirection >= 0)
                {
                    nextRoomIndex = lastRoomIndex - movesInDirection;
                }
                else
                {
                    nextRoomIndex = 0;
                }
            }
            else
            {
                if (lastRoomIndex + movesInDirection < numberOfRooms)
                {
                    nextRoomIndex = lastRoomIndex + movesInDirection;
                }
                else
                {
                    nextRoomIndex = numberOfRooms - 1;
                }
            }

            // change the state of the room if there is a movement
            if (nextRoomIndex != lastRoomIndex)
            {
                if (roomsState[nextRoomIndex] == "L")
                {
                    roomsState[nextRoomIndex] = "D";
                }
                else
                {
                    roomsState[nextRoomIndex] = "L";
                }
            }
            lastRoomIndex = nextRoomIndex;
        }

        int numberOfPrayers = 0;
        int darkRoomsCounter = 0;

        for (int i = 0; i < numberOfRooms; i++)
        {
            if (roomsState[i] == "D")
            {
                darkRoomsCounter++;
            }
        }
        numberOfPrayers = 'D' * darkRoomsCounter;
        Console.WriteLine(numberOfPrayers);
    }
}
