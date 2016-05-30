using System;
using System.Collections.Generic;
using System.Linq;

class SimpleTextEditor2
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());

        string text = string.Empty;
        Stack<string> trackChanges = new Stack<string>();
        trackChanges.Push(text);

        for (int i = 0; i < n; i++)
        {
            string[] commandLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (commandLine[0])
            {
                case "1":
                    {
                        text += commandLine[1];
                        trackChanges.Push(text);
                    }
                    break;
                case "2":
                    {
                        text = text.Substring(0, text.Length - int.Parse(commandLine[1]));
                        trackChanges.Push(text);
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine(text[int.Parse(commandLine[1]) - 1]);
                    }
                    break;
                case "4":
                    {
                        trackChanges.Pop();
                        text = trackChanges.Peek();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
