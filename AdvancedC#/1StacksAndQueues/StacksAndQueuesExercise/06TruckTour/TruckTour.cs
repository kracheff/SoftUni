using System;
using System.Collections.Generic;
public class TruckTour
{
    public static void Main()
    {
        int numberOfPumps = int.Parse(Console.ReadLine());
        Queue<string> pumps = new Queue<string>();
        Queue<int> indexes = new Queue<int>();

        for (int i = 0; i < numberOfPumps; i++)
        {
            pumps.Enqueue(Console.ReadLine());
            indexes.Enqueue(i);
        }

        int currentIndex = 0;
        int finalIndex = 0;
        int pumpsCounter = 1;
        int indexCounter = 0;
        int totalPetrol = 0;

        while (pumpsCounter < numberOfPumps)
        {
            string currentPump = pumps.Peek();
            string[] pumpData = currentPump.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int amountOfPertol = int.Parse(pumpData[0]);
            int distanceToNextPump = int.Parse(pumpData[1]);
            currentIndex = indexes.Peek();
            totalPetrol += amountOfPertol;

            if (totalPetrol >= distanceToNextPump)
            {
                if (indexCounter == 0)
                {
                    finalIndex = currentIndex;
                }
                pumpsCounter++;
                indexCounter++;
                totalPetrol -= distanceToNextPump;
            }
            else
            {
                pumpsCounter = 1;
                indexCounter = 0;
                totalPetrol = 0;
            }

            pumps.Enqueue(currentPump);
            pumps.Dequeue();

            indexes.Enqueue(currentIndex);
            indexes.Dequeue();
        }
        Console.WriteLine(finalIndex);
    }
}
