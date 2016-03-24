using System;
class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        bool bonus10 = score >= 1 && score <= 3;
        bool bonus100 = score >= 4 && score <= 6;
        bool bonus1000 = score >= 7 && score <= 9;

        if (bonus10)
        {
            Console.WriteLine(score * 10);
        }
        else if (bonus100)
        {
            Console.WriteLine(score * 100);
        }
        else if (bonus1000)
        {
            Console.WriteLine(score * 1000);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}
