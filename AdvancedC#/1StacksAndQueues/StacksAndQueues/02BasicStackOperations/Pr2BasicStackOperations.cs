using System;
using System.Collections.Generic;
public class Pr2BasicStackOperations
{
    public static void Main()
    {
        Stack<int> numbers = new Stack<int>();

        string[] inputElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int elementsToPush = int.Parse(inputElements[0]);
        int elementsToPop = int.Parse(inputElements[1]);
        int elementToCheck = int.Parse(inputElements[2]);

        string[] stackElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < stackElements.Length; i++)
        {
            numbers.Push(int.Parse(stackElements[i]));
        }
        for (int i = 0; i < elementsToPop; i++)
        {
            numbers.Pop();
        }
        if (numbers.Contains(elementToCheck))
        {
            Console.WriteLine("true");
        }
        else
        {
            try
            {
                Console.WriteLine(numbers.Peek());
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }
        }
    }
}
