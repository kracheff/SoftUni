using System;
using System.Collections.Generic;
public class PhoneBook
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string name;
        string phoneNumber;

        while (input != "search" && input != "stop")
        {
            name = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)[0];
            phoneNumber = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)[1];

            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, phoneNumber);
            }
            else
            {
                phonebook[name] = phoneNumber;
            }
            input = Console.ReadLine();
        }

        if (input == "search")
        {
            name = Console.ReadLine();
            while (name != "stop")
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
                name = Console.ReadLine();
            }
        }
    }
}
