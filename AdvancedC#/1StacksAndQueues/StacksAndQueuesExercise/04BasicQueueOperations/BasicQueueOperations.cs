using System;
using System.Collections.Generic;
public class BasicQueueOperations
{
    public static void Main()
    {
        Queue<int> queue = new Queue<int>();
        Stack<int> minValue = new Stack<int>();

        string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int elementsToEnqueue = int.Parse(commands[0]);
        int elementsToDequeue = int.Parse(commands[1]);
        int elementToCheck = int.Parse(commands[2]);

        string[] elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int min = int.MaxValue;

        for (int i = 0; i < elementsToEnqueue; i++)
        {
            queue.Enqueue(int.Parse(elements[i]));
        }

        for (int i = 0; i < elementsToDequeue; i++)
        {
            if (queue.Count != 0)
            {
                queue.Dequeue();
            }
        }

        if (queue.Contains(elementToCheck))
        {
            Console.WriteLine("true");
        }
        else
        {
            if (queue.Count != 0)
            {
                int[] whatsLeft = queue.ToArray();

                for (int i = 0; i < whatsLeft.Length; i++)
                {
                    if (whatsLeft[i] < min)
                    {
                        min = whatsLeft[i];
                    }
                }
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}
