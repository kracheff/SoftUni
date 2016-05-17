using System;
using System.Collections.Generic;
public class CalcSequenceWithQueue
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Queue<long> queue = new Queue<long>();
        Console.Write(n + " ");

        queue.Enqueue(n);

        for (int i = 0; i < 49; i++)
        {
            long currentNumber;
            if (i % 3 == 0)
            {
                currentNumber = queue.Peek() + 1;
                queue.Enqueue(currentNumber);
                PrintCurrentNumber(i, currentNumber);
            }
            else if (i % 3 == 1)
            {
                currentNumber = 2 * queue.Peek() + 1;
                queue.Enqueue(currentNumber);
                PrintCurrentNumber(i, currentNumber);
            }
            else if (i % 3 == 2)
            {
                currentNumber = queue.Peek() + 2;
                queue.Enqueue(currentNumber);
                queue.Dequeue();
                PrintCurrentNumber(i, currentNumber);
            }
        }
    }
    public static void PrintCurrentNumber(int i, long currentNumber)
    {
        if (i != 48)
        {
            Console.Write(currentNumber + " ");
        }
        else
        {
            Console.Write(currentNumber);
        }
    }
}
