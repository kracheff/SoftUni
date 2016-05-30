using System;
using System.Collections.Generic;
using System.Numerics;

public class MinerTask
{
    public static void Main()
    {
        Dictionary<string, BigInteger> database = new Dictionary<string, BigInteger>();
        string resource = Console.ReadLine();
        BigInteger quantity = 0;

        if (resource != null)
        {
            string input = Console.ReadLine();
            if (input != null)
            {
                quantity = BigInteger.Parse(input);
            }

            while (input != "stop")
            {
                if (!database.ContainsKey(resource))
                {
                    database.Add(resource, quantity);
                }
                else
                {
                    database[resource] = BigInteger.Add(database[resource], quantity);
                }

                input = Console.ReadLine();

                if (input != "stop")
                {
                    resource = input;
                    quantity = BigInteger.Parse(Console.ReadLine());
                }
            }

            foreach (var kvp in database)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
