using System;
using System.Collections.Generic;
using System.Text;

public class SimpleTextEditor
{
    public static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        StringBuilder text = new StringBuilder();
        Stack<string> trackChanges = new Stack<string>();
        trackChanges.Push(text.ToString());

        for (int i = 0; i < n; i++)
        {
            string command = Console.ReadLine().Trim();
            string[] splitCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string operation = splitCommand[0];
            string argument;

            switch (operation)
            {
                case "1":
                    argument = splitCommand[1]; ;
                    text.Append(argument);
                    trackChanges.Push(text.ToString());
                    break;
                case "2":
                    argument = splitCommand[1]; ;
                    text.Remove(text.Length - int.Parse(argument), int.Parse(argument));
                    trackChanges.Push(text.ToString());
                    break;
                case "3":
                    argument = splitCommand[1]; ;
                    Console.WriteLine(text.ToString()[int.Parse(argument) - 1]);
                    break;
                case "4":
                    if (trackChanges.Count != 0)
                    {
                        trackChanges.Pop();
                    }
                    text = new StringBuilder(trackChanges.Peek());
                    break;
                default:
                    break;
            }
        }
    }
}

