using System;
using System.Collections.Generic;
public class FixEmails
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string email = Console.ReadLine();
        string input = string.Empty;

        Dictionary<string, string> namesAndEmails = new Dictionary<string, string>();

        while (input != "stop" && input != null)
        {
            if (email.Substring(email.Length - 2) != "us" && email.Substring(email.Length - 2) != "uk")
            {
                if (!namesAndEmails.ContainsKey(name))
                {
                    namesAndEmails.Add(name, email);
                }
                else
                {
                    namesAndEmails[name] = email;
                }
            }
            input = Console.ReadLine();
            if (input != "stop" && input != null)
            {
                name = input;
                email = Console.ReadLine();
            }
        }
        foreach (var kvp in namesAndEmails)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}


