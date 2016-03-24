using System;



class RandomizeTheNumbers_1_N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        int randomNumber = 1;
        int countNumbers = 0;
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            randomNumber = random.Next(1, n + 1);
            num[i] = randomNumber;
        }
        for (int i = 0; i < n; i++)
        {
            for (int b = i + 1; b < n; b++)
            {
                if (num[i] == num[b])
                {
                    num[b] = 0;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            randomNumber = random.Next(1, n + 1);
            if (num[i] == 0)
            {
                i--;
            }
            for (int b = 0; b < n; b++)
            {
                if (num[b] == randomNumber)
                {
                    randomNumber = random.Next(1, n + 1);
                    countNumbers = 0;
                    b--;
                }
                else
                {
                    countNumbers++;
                }
            }
            if (countNumbers == n)
            {
                countNumbers = 0;
                for (i = 0; i < n; i++)
                {
                    if (num[i] == 0)
                    {
                        num[i] = randomNumber;
                        break;
                    }
                }
            }
        }
        foreach (var item in num)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

