using System;
using System.Numerics;

class PetarsGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        string final = string.Empty;

        BigInteger sum = 0;

        for (ulong i = startNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }

        // if sum % 2 != 0 ---> replace LAST digit

        string sumText = sum.ToString();
        int sumLength = sumText.Length;

        if (sum % 2 != 0)
        {
            string lastDigit = sumText[sumLength - 1].ToString();

            final = sumText.Replace(lastDigit, replacement);

            //for (int i = 0; i < sumLength; i++)
            //{
            //    if (sumText[i] == lastDigit)
            //    {
            //        Console.Write(replacement);
            //    }
            //    else
            //    {
            //        Console.Write(sumText[i]);
            //    }
            //}
        }

        // if sum % 2 == 0 ---> replace FIRST digit

        if (sum % 2 == 0)
        {
            string firstDigit = sumText[0].ToString();

            final = sumText.Replace(firstDigit, replacement).ToString();


            //for (int i = 0; i < sumLength; i++)
            //{
            //    if (sumText[i] == firstDigit)
            //    {
            //        Console.Write(replacement);
            //    }
            //    else
            //    {
            //        Console.Write(sumText[i]);
            //    }
            //}
        }
        Console.WriteLine(final);
    }
}
