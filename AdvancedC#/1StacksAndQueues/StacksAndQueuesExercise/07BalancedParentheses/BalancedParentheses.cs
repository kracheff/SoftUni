using System;
using System.Collections.Generic;
public class BalancedParentheses
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim();
        Stack<char> stack = new Stack<char>();

        if (input.Length <= 1)
        {
            Console.WriteLine("NO");
            return;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(' || input[i] == '{' || input[i] == '[')
            {
                stack.Push(input[i]);
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    if (input[i] == ')')
                    {
                        if (input[i] != stack.Pop() + 1)
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        if (input[i] != stack.Pop() + 2)
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }
        }
        Console.WriteLine("YES");
    }
}

