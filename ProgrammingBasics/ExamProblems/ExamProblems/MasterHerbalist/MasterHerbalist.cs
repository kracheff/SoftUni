using System;

class MasterHerbalist
{
    static void Main()
    {
        int dailyExpences = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int counterOfDays = 0;
        int totalMoney = 0;
        while (input != "Season Over")
        {
            string[] splitInput = input.Split();
            int hours = int.Parse(splitInput[0]);
            string path = splitInput[1];
            int herbPrice = int.Parse(splitInput[2]);
            string[] pathsPerDay = new string[hours];
            for (int i = 0, counter = 0; i < pathsPerDay.Length; i++, counter++)
            {
                if (counter == path.Length)
                {
                    counter = 0;
                }
                pathsPerDay[i] = path[counter].ToString();
            }
            int hCounter = 0;
            for (int i = 0; i < pathsPerDay.Length; i++)
            {
                if (pathsPerDay[i] == "H")
                {
                    hCounter++;
                }
            }
            totalMoney += hCounter * herbPrice;
            counterOfDays++;
            input = Console.ReadLine();
        }
        double averageMoney = totalMoney / (double)counterOfDays;
        double profitLoss = averageMoney - dailyExpences;
        if (profitLoss < 0)
        {
            Console.WriteLine("We are in the red. Money needed: {0:0}.",
                dailyExpences * counterOfDays - totalMoney);
        }
        else
        {
            Console.WriteLine("Times are good. Extra money per day: {0:0.00}.", profitLoss);
        }
    }
}