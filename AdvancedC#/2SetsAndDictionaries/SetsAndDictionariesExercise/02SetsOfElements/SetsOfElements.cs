using System;
using System.Collections.Generic;
public class SetsOfElements
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int firstSetCount = int.Parse(input[0]);
        int secondSetCount = int.Parse(input[1]);
        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        for (int i = 0; i < firstSetCount; i++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < secondSetCount; i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> repeatingElements = new HashSet<int>();

       firstSet.IntersectWith(secondSet);
        Console.WriteLine(String.Join(" ", firstSet));
    }
}