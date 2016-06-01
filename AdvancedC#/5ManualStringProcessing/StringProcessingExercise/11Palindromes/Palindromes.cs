using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Palindromes
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] text = input.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> pal = new SortedSet<string>();

        foreach (var word in text)
        {
            string tempWord = string.Empty;
            Stack<char> stack = new Stack<char>();
            bool isPalindrom = true;

            if (word.Length == 1)
            {
                pal.Add(word);
            }
            else
            {
                if (word.Length % 2 == 1)
                {
                    tempWord = word.Remove(word.Length / 2, 1);
                }
                else
                {
                    tempWord = word;
                }
                for (int i = 0; i < tempWord.Length / 2; i++)
                {
                    stack.Push(tempWord[i]);
                }
                for (int i = tempWord.Length / 2; i < tempWord.Length; i++)
                {
                    if (tempWord[i] != stack.Pop())
                    {
                        isPalindrom = false;
                        break;
                    }
                }
                if (isPalindrom)
                {
                    pal.Add(word);
                }
            }
        }
        Console.WriteLine($"[{string.Join(", ", pal)}]");
    }
}
