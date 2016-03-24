using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HungryGarfield
{
    static void Main()
    {
        decimal receivedDollars = decimal.Parse(Console.ReadLine());
        decimal exchangeRate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        uint pizzaQuantity = uint.Parse(Console.ReadLine());
        uint lasagnaQuantity = uint.Parse(Console.ReadLine());
        uint sandwichQuantity = uint.Parse(Console.ReadLine());

        decimal moneyNeeded =
            ((pizzaPrice / exchangeRate) * pizzaQuantity) +
            ((lasagnaPrice / exchangeRate) * lasagnaQuantity) +
            ((sandwichPrice / exchangeRate) * sandwichQuantity);

        //Console.WriteLine(moneyNeeded);

        if (moneyNeeded <= receivedDollars)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:0.00}.",
                receivedDollars - moneyNeeded);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:0.00}.",
                moneyNeeded - receivedDollars);
        }
    }
}
