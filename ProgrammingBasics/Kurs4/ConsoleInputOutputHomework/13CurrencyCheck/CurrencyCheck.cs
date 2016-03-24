using System;
class CurrencyCheck
{
    static void Main()
    {
        // Exchange rates

        // rublles - 1 RUB = 0.035 BGN

        decimal rub = 0.035m;

        // dollars - 1 USD = 1.5 BGN

        decimal usd = 1.5m;

        // euros - 1 EUR = 1.95 BGN

        decimal eur = 1.95m;

        // BGN 1 B. 2 for the price of 1 (1 costs 1/2 both)
        // BGN 2 M. (normal price)

        uint r = uint.Parse(Console.ReadLine());
        uint d = uint.Parse(Console.ReadLine());
        uint e = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint m = uint.Parse(Console.ReadLine());

        decimal rubPrice = r * rub;
        decimal usdPrice = d * usd;
        decimal eurPrice = e * eur;
        decimal bgnBPrice = b / 2m;

        decimal cheapestGame = Math.Min(rubPrice, Math.Min(usdPrice, Math.Min(eurPrice, Math.Min(bgnBPrice, m))));

        Console.WriteLine("{0:0.00}", cheapestGame);
    }
}

