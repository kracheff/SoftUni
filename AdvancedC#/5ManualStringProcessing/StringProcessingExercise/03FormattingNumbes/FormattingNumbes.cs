using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FormattingNumbes
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int firstNumber = int.Parse(input[0]);
        double secondNumber = double.Parse(input[1]);
        double thirdNumber = double.Parse(input[2]);
        string firstToBinary = Convert.ToString(firstNumber, 2).PadLeft(10, '0').Substring(0, 10);

        Console.WriteLine("|{0, -10:X}|{1}|{2, 10:0.00}|{3, -10:0.000}|",
            firstNumber,
            firstToBinary,
            secondNumber,
            thirdNumber);
    }
}
