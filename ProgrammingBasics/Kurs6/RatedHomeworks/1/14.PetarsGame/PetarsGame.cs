using System;

class PetarsGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        decimal sum = 0;
        string stringSum;
        string replaceDigit;
        string finalSum;
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
        if (sum % 2 != 0)
        {
            stringSum = Convert.ToString(sum);
            replaceDigit = stringSum[stringSum.Length - 1].ToString();
        }
        else
        {
            stringSum = Convert.ToString(sum);
            replaceDigit = stringSum[0].ToString();
        }

        finalSum = Convert.ToString(sum).Replace(replaceDigit, replacement);
        Console.WriteLine(finalSum);
        Console.ReadLine();
    }
}
