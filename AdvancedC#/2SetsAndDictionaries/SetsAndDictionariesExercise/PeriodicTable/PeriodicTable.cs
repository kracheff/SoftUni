using System;
using System.Collections.Generic;
public class PeriodicTable
{
    public static void Main()
    {
        int linesToRead = int.Parse(Console.ReadLine());
        SortedSet<string> uniqueElements = new SortedSet<string>();

        for (int i = 0; i < linesToRead; i++)
        {
            string[] elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in elements)
            {
                uniqueElements.Add(item);
            }
        }
        Console.WriteLine(string.Join(" ", uniqueElements));
    }
}
