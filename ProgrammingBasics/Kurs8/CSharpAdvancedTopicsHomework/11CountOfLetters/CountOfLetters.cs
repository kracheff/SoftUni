using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputElements = input.Split(' ');
            int numberOfOccurances = 0;

            Dictionary<string, int> dataTable = new Dictionary<string, int>();

            List<string> uniqueLetters = new List<string>();

            for (int i = 0; i < inputElements.Length; i++)
            {
                if (!uniqueLetters.Contains(inputElements[i]))
                {
                    uniqueLetters.Add(inputElements[i]);
                }
            }
            uniqueLetters.Sort();

            for (int i = 0; i < uniqueLetters.Count; i++)
            {
                for (int j = 0; j < inputElements.Length; j++)
                {
                    if (uniqueLetters[i] == inputElements[j])
                    {
                        numberOfOccurances++;
                    }
                }
                dataTable.Add(uniqueLetters[i], numberOfOccurances);
                numberOfOccurances = 0;
            }

            foreach (var item in dataTable)
            {
                Console.WriteLine("{0} -> {1}" , item.Key, item.Value );
            }
        }
    }
}
