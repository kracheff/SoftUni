using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PassionDays
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());

        int numberOfPurchases = 0;

        string command = Console.ReadLine();

        while (command != "mall.Enter")
        {

        }

        if (command == "mall.Enter")
        {
            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] >= 65 && command[i] <= 90)
                    {
                        if (money - (command[i] * 0.5m) >= 0)
                        {
                            money -= command[i] * 0.5m;
                            numberOfPurchases++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (command[i] >= 97 && command[i] <= 122)
                    {
                        if (money - (command[i] * 0.3m) >= 0)
                        {
                            money -= command[i] * 0.3m;
                            numberOfPurchases++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (command[i] == '%')
                    {
                        money *= 0.5m;
                        numberOfPurchases++;
                    }
                    else if (command[i] == '*')
                    {
                        money += 10m;
                    }
                    else
                    {
                        if (money - command[i] >= 0)
                        {
                            money -= command[i];
                            numberOfPurchases++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                command = Console.ReadLine();
            }
        }
        else
        {
            command = Console.ReadLine();
        }

        if (numberOfPurchases == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:F2} lv.", money);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", numberOfPurchases, money);
        }
    }
}
