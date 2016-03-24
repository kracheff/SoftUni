using System;
class OddEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');
        int sumOdds = 1;
        int sumEvens = 1;

        for (int i = 0; i < splitInput.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdds *= int.Parse(splitInput[i]);
            }
            else
            {
                sumEvens *= int.Parse(splitInput[i]);
            }
        }
        if (sumEvens == sumOdds)
        {
            Console.WriteLine("yes");
            Console.WriteLine(sumOdds);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + sumOdds);
            Console.WriteLine("even_product = " + sumEvens);
        }
    }
}
