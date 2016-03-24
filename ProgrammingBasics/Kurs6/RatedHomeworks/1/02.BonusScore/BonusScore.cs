using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine());
        
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                Console.WriteLine(score);
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                Console.WriteLine(score);
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                Console.WriteLine(score);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }

        // Solution with if statements: 

            //if (score >= 1 && score <= 3)
            //        {
            //            score *= 10;
            //            Console.WriteLine("Result: {0}", score);
            //        }
            //        else if (score >= 4 && score <= 6)
            //        {
            //            score *= 100;
            //            Console.WriteLine("Result: {0}", score);
            //        }
            //        else if (score >= 7 && score <= 9)
            //        {
            //            score *= 1000;
            //            Console.WriteLine("Result: {0}", score);
            //        }
            //        else if (score <= 0 || score > 9)
            //        {
            //            Console.WriteLine("Invalid score");
            //        }

    }
}

