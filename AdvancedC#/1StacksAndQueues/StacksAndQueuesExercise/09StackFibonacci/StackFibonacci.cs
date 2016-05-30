using System;
using System.Collections.Generic;

public class StackFibonacci
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<long> stack = new Stack<long>();
        stack.Push(1);
        stack.Push(1);

        for (int i = 0; i < n - 2; i++)
        {
            long lastLastNumber = stack.Peek();
            long lastNumber = stack.Pop() + stack.Pop();

            stack.Push(lastLastNumber);
            stack.Push(lastNumber);
        }
        Console.WriteLine(stack.Peek());
    }
}