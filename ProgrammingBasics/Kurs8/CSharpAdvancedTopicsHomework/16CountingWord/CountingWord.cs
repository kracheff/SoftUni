using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16CountingWord
{
    class CountingWord
    {
        static void Main(string[] args)
        {
            List<char> allDelimiters = new List<char>();

            for (int i = 0; i < 65; i++)
            {
                allDelimiters.Add((char)i);
            }

            for (int i = 91; i < 97; i++)
            {
                allDelimiters.Add((char)i);

            }
            for (int i = 123; i < 127; i++)
            {
                allDelimiters.Add((char)i);
            }

            char[] delimiters = new char[75];

            for (int i = 0; i < allDelimiters.Count; i++)
            {
                delimiters[i] = allDelimiters[i];
            }

            string word = Console.ReadLine();
            string text = Console.ReadLine();
            int counter = 0;

            string[] splitText = text.Split(delimiters, 
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitText.Length; i++)
            {
                if (splitText[i].ToLower() == word.ToLower())
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
