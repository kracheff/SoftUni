using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayMatcher
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split('\\');

        string leftArray = splitInput[0];
        string rightArray = splitInput[1];
        string command = splitInput[2];

        List<char> output = new List<char>();

        switch (command)
        {
            case "join":
                for (int i = 0; i < rightArray.Length; i++)
                {
                    for (int j = 0; j < leftArray.Length; j++)
                    {
                        if (rightArray[i] == leftArray[j])
                        {
                            output.Add(rightArray[i]);
                        }
                    }
                }
                break;

            case "left exclude":
                for (int i = 0; i < rightArray.Length; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < leftArray.Length; j++)
                    {
                        if (rightArray[i] == leftArray[j])
                        {
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        output.Add(rightArray[i]);
                    }
                }
                break;

            case "right exclude":
                for (int i = 0; i < leftArray.Length; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < rightArray.Length; j++)
                    {
                        if (leftArray[i] == rightArray[j])
                        {
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        output.Add(leftArray[i]);
                    }
                }

                break;

            default:break;
        }
        output.Sort();
        for (int i = 0; i < output.Count; i++)
        {
            Console.Write(output[i]);
        }
        Console.WriteLine();
    }
}
