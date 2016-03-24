using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        ulong asciiSumOdd = 0;
        ulong asciiSumEven = 0;
        string oddLetters = string.Empty;
        string evenLetters = string.Empty;

        string[] elementsOfInput = input.Split(' ');

        for (int i = 0; i < elementsOfInput.Length; i++)
        {
            for (int j = 0; j < elementsOfInput[i].Length; j+=2)
            {
                oddLetters += elementsOfInput[i][j];
                if (j < elementsOfInput[i].Length - 1)
                {
                    evenLetters += elementsOfInput[i][j + 1];
                }

            }
            oddLetters = oddLetters.ToLower();
            evenLetters = evenLetters.ToLower();
        }

        for (int i = 0; i < oddLetters.Length; i++)
        {
            if ((i + 1) % oddJump != 0)
            {
                asciiSumOdd += oddLetters[i];
            }
            else
            {
                asciiSumOdd *= oddLetters[i];
            }
        }

        for (int i = 0; i < evenLetters.Length; i++)
        {
            if ((i + 1) % evenJump != 0)
            {
                asciiSumEven += evenLetters[i];
            }
            else
            {
                asciiSumEven *= evenLetters[i];
            }
        }

        Console.WriteLine("Odd: {0:X}", asciiSumOdd);
        Console.WriteLine("Even: {0:X}", asciiSumEven);
    }
}
