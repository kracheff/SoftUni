using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseString
{
    public static void Main()
    {
        string input = Console.ReadLine();

        char[] inputToChar = input.ToCharArray();
        Array.Reverse(inputToChar);
        Console.WriteLine(new string (inputToChar));

    }
}