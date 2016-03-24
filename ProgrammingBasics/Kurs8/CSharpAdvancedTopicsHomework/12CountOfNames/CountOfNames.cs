using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            int numberOfOccurances = 0;
            List<string> uniqueNames = new List<string>();
            Dictionary<string, int> namesList = new Dictionary<string, int>();

            for (int i = 0; i < elements.Length; i++)
            {
                if (!uniqueNames.Contains(elements[i]))
                {
                    uniqueNames.Add(elements[i]);
                }
            }
            uniqueNames.Sort();

            for (int i = 0; i < uniqueNames.Count; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (uniqueNames[i] == elements[j])
                    {
                        numberOfOccurances++;
                    }
                }
                namesList.Add(uniqueNames[i], numberOfOccurances);
                numberOfOccurances = 0;
            }

            foreach (var item in namesList)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
