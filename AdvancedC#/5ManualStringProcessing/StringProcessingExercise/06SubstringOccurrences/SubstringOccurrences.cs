using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SubstringOccurrences
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string searchString = Console.ReadLine().ToLower();
        int numberOfOccurrences = 0;

        for (int i = 0; i <= text.Length - searchString.Length; i++)
        {
            if (searchString == text.Substring(i, searchString.Length))
            {
                numberOfOccurrences++;
            }
        }

        Console.WriteLine(numberOfOccurrences);
    }
}