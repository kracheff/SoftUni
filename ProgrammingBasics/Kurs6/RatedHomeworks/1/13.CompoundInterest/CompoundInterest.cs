using System;

class CompoundInterest
{
    static void Main()
    {
        decimal presentValue = decimal.Parse(Console.ReadLine());
        uint term = uint.Parse(Console.ReadLine());
        double bankInterestRate = double.Parse(Console.ReadLine());
        double friendInterestRate = double.Parse(Console.ReadLine());

        decimal bankFutureValue = presentValue * (decimal)Math.Pow((1 + bankInterestRate), term);
        decimal friendFutureValue = presentValue*((decimal)friendInterestRate  + 1);

        if (friendFutureValue <= bankFutureValue)
        {
            Console.WriteLine("{0:F2} Friend", friendFutureValue);
        }
        else
        {
            Console.WriteLine("{0:F2} Bank", bankFutureValue);
        }

    }
}
