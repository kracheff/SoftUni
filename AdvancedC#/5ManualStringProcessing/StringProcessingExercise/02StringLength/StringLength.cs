using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringLength
{
    public static void Main()
    {
        string input = Console.ReadLine();
        input.
        string output = string.Empty;

        if (input.Length < 20)
        {
            Console.WriteLine(input + "********************".Substring(0, 20 - input.Length)); 
        }
        else
        {
            Console.WriteLine(input.Substring(0, 20));
        }
    }
}
