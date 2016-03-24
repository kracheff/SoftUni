using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncryptedMatrix                      // Programming Basics Exam 29 March 2015 Morning
{

    static void Main()
    {

        string inputMessage = Console.ReadLine();
        int[] inputAsciiNumbers = new int[inputMessage.Length];
        char matrixDirection = char.Parse(Console.ReadLine());

        for (int i = 0; i < inputMessage.Length; i++)
        {
            inputAsciiNumbers[i] = inputMessage[i];
        }

        int[] lastAsciiNumbers = new int[inputAsciiNumbers.Length];

        for (int i = 0; i < inputAsciiNumbers.Length; i++)
        {
            lastAsciiNumbers[i] = inputAsciiNumbers[i] % 10;
        }

        int[] convertedAsciiNumbers = new int[lastAsciiNumbers.Length];

        for (int i = 0; i < lastAsciiNumbers.Length; i++)
        {

            if (lastAsciiNumbers[i] % 2 == 0 || lastAsciiNumbers[i] == 0)
            {
                convertedAsciiNumbers[i] = lastAsciiNumbers[i] * lastAsciiNumbers[i];
            }
            else
            {
                if (i == 0)
                {
                    if (lastAsciiNumbers.Length > 1)
                    {
                        convertedAsciiNumbers[i] += lastAsciiNumbers[i] + lastAsciiNumbers[i + 1];
                    }
                    else
                    {
                        convertedAsciiNumbers[i] = lastAsciiNumbers[i];
                    }
                }
                else if (i == lastAsciiNumbers.Length - 1)
                {
                    convertedAsciiNumbers[i] += lastAsciiNumbers[i] + lastAsciiNumbers[lastAsciiNumbers.Length - 2];
                }
                else
                {
                    convertedAsciiNumbers[i] += lastAsciiNumbers[i] + lastAsciiNumbers[i - 1] + lastAsciiNumbers[i + 1];
                }
            }
        }

        string asciiNumbersToString = string.Empty;

        for (int i = 0; i < convertedAsciiNumbers.Length; i++)
        {
            asciiNumbersToString += convertedAsciiNumbers[i];
        }

        int[] finalNumbers = new int[asciiNumbersToString.Length];

        for (int i = 0; i < asciiNumbersToString.Length; i++)
        {
            finalNumbers[i] = asciiNumbersToString[i];
        }

        // make the matrix

        char[,] matrix = new char[finalNumbers.Length, finalNumbers.Length];

        if (matrixDirection == '\\')
        {

            for (int i = 0; i < finalNumbers.Length; i++)
            {
                for (int j = 0; j < finalNumbers.Length; j++)
                {
                    matrix[i, j] = '0';
                    matrix[i, i] = (char)finalNumbers[i];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[(char)i, (char)j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Array.Reverse(finalNumbers);

            for (int i = 0; i < finalNumbers.Length; i++)
            {
                for (int j = 0; j < finalNumbers.Length; j++)
                {
                    matrix[i, j] = '0';
                    matrix[i, finalNumbers.Length - i - 1] = (char)finalNumbers[i];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[(char)i, (char)j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
