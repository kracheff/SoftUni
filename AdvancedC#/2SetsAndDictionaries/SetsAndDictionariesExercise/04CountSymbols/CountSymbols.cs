using System;
using System.Collections.Generic;
public class CountSymbols
{
   public static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> symbolOccurences = new SortedDictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!symbolOccurences.ContainsKey(input[i]))
            {
                symbolOccurences[input[i]] = 0;
            }
            symbolOccurences[input[i]]++;
        }

        foreach (var kvp in symbolOccurences)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}
