using System;
using System.Collections.Generic;

public class StacksExercise
{
    public static void Main()
    {
        Stack<int> numbers = new Stack<int>();

        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length; i++)
        {
            numbers.Push(int.Parse(input[i]));
        }

        int stackCount = numbers.Count;
        string output = string.Empty;

        for (int i = 0; i < stackCount; i++)
        {
            output += numbers.Pop() + " ";
        }
        Console.WriteLine(output.Trim());
    }
}
