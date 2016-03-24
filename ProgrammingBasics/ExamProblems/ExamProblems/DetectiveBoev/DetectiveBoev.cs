using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();
        int wordSum = 0;

        // find the sum of all chars of the secret word
        for (int i = 0; i < secretWord.Length; i++)
        {
            wordSum += secretWord[i];
        }

        // find the sum of all digits of the sum of the secred word (the MASK)
        int mask = 10;

        while (mask > 9)
        {
            mask = 0;
            int sumLength = wordSum.ToString().Length;
            int[] sum = new int[sumLength];
            int remainder = 0;

            for (int i = 0; i < sumLength; i++)
            {
                remainder = wordSum % 10;
                sum[i] = remainder;
                wordSum /= 10;
            }
            mask = sum.Sum();
            wordSum = mask;
        }

        // decript the message using the mask
        int[] decriptedMessage = new int[encryptedMessage.Length];

        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if (encryptedMessage[i] % mask == 0)
            {
                decriptedMessage[i] = encryptedMessage[i] + mask;
              //  Console.WriteLine((char)decriptedMessage[i]);                 //
            }
            else
            {
                decriptedMessage[i] = encryptedMessage[i] - mask;
            //    Console.WriteLine((char)decriptedMessage[i]);                //

            }
        }
        Array.Reverse(decriptedMessage);

        for (int i = 0; i < decriptedMessage.Length; i++)
        {
            Console.Write((char)decriptedMessage[i]);
        }
        Console.WriteLine();
    }
}
