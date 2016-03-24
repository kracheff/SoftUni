using System;
class CompoundInterest
{
    static void Main()
    {
        double priceOfTV = double.Parse(Console.ReadLine());
        int loanMaturity = int.Parse(Console.ReadLine());
        double bankInterestRate = double.Parse(Console.ReadLine());
        double friendInterestRate = double.Parse(Console.ReadLine());

        double bankLoan = priceOfTV * (Math.Pow((1 + bankInterestRate), loanMaturity));
        double friendLoan = priceOfTV * (1 + friendInterestRate);

        if (bankLoan < friendLoan)
        {
            Console.WriteLine("{0:F} {1}", bankLoan, "Bank");
        }
        else
        {
            Console.WriteLine("{0:F} {1}", friendLoan, "Friend");
        }
    }
}
