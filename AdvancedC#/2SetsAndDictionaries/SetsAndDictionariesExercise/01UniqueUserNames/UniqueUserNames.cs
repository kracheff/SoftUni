using System;
using System.Collections.Generic;
public class UniqueUserNames
{
    public static void Main()
    {
        HashSet<string> userNames = new HashSet<string>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            userNames.Add(Console.ReadLine());
        }
        foreach (var item in userNames)
        {
            Console.WriteLine(item);
        }
    }
}