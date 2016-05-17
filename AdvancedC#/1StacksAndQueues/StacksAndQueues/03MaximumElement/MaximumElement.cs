using System;
using System.Collections.Generic;
public class MaximumElement
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> maxValues = new Stack<int>();

        for (int i = 0; i < n; i++)
        {

            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (command[0] == "1")
            {
                int maxElement;
                if (stack.Count > 0)
                {
                    maxElement = maxValues.Peek();
                }
                else
                {
                    maxElement = int.MinValue;
                }
                stack.Push(int.Parse(command[1]));
                if (stack.Peek() > maxElement)
                {
                    maxValues.Push(stack.Peek());
                }
            }
            else if (command[0] == "2")
            {
                
                try
                {
                    if (stack.Peek() == maxValues.Peek())
                    {
                        maxValues.Pop();

                    }
                    stack.Pop();
                }
                catch (Exception)
                {
                    continue;
                }
            }
            else if (command[0] == "3")
            {
                Console.WriteLine(maxValues.Peek());
            }
        }
    }
}
