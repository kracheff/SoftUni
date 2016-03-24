using System;
class BasketBattle
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine(); //Simeon or Nakov
        byte numberOfRounds = byte.Parse(Console.ReadLine());
        short scoreSimeon = 0;
        short scoreNakov = 0;
        bool isSimeonFirst = false; // first player is Nakov. Second player is Simeon
        if (firstPlayer == "Simeon")
        {
            isSimeonFirst = true; // first player is Simeon. Second player is Nakov
        }

        for (int i = 1; i <= numberOfRounds; i++)
        {
            short pointsAttempted1 = short.Parse(Console.ReadLine());
            string successOrFail1 = Console.ReadLine(); // success or fail
            if (successOrFail1 == "success")
            {
                if (isSimeonFirst == true)
                {
                    scoreSimeon += pointsAttempted1;

                    if (scoreSimeon > 500)
                    {
                        scoreSimeon -= pointsAttempted1;
                    }
                    if (scoreSimeon == 500)
                    {
                        Console.WriteLine("Simeon");
                        Console.WriteLine(i);
                        Console.WriteLine(scoreNakov);
                        return;
                    }
                    short pointsAttempted2 = short.Parse(Console.ReadLine());
                    string successOrFail2 = Console.ReadLine();
                    if (successOrFail2 == "success")
                    {
                        scoreNakov += pointsAttempted2;

                        if (scoreNakov > 500)
                        {
                            scoreNakov -= pointsAttempted2;
                        }
                        if (scoreNakov == 500)
                        {
                            Console.WriteLine("Nakov");
                            Console.WriteLine(i);
                            Console.WriteLine(scoreSimeon);
                            return;
                        }
                    }
                }
                else
                {
                    scoreNakov += pointsAttempted1;

                    if (scoreNakov > 500)
                    {
                        scoreNakov -= pointsAttempted1;
                    }
                    if (scoreNakov == 500)
                    {
                        Console.WriteLine("Nakov");
                        Console.WriteLine(i);
                        Console.WriteLine(scoreSimeon);
                        return;
                    }
                    short pointsAttempted2 = short.Parse(Console.ReadLine());
                    string successOrFail2 = Console.ReadLine();
                    if (successOrFail2 == "success")
                    {
                        scoreSimeon += pointsAttempted2;

                        if (scoreSimeon > 500)
                        {
                            scoreSimeon -= pointsAttempted2;
                        }
                        if (scoreSimeon == 500)
                        {
                            Console.WriteLine("Simeon");
                            Console.WriteLine(i);
                            Console.WriteLine(scoreNakov);
                            return;
                        }
                    }
                }
            }
            else
            {
                if (isSimeonFirst == true)
                {
                    short pointsAttempted2 = short.Parse(Console.ReadLine());
                    string successOrFail2 = Console.ReadLine();
                    if (successOrFail2 == "success")
                    {
                        scoreNakov += pointsAttempted2;

                        if (scoreNakov > 500)
                        {
                            scoreNakov -= pointsAttempted2;
                        }
                        if (scoreNakov == 500)
                        {
                            Console.WriteLine("Nakov");
                            Console.WriteLine(i);
                            Console.WriteLine(scoreSimeon);
                            return;
                        }
                    }
                }

                else
                {
                    short pointsAttempted2 = short.Parse(Console.ReadLine());
                    string successOrFail2 = Console.ReadLine();
                    if (successOrFail2 == "success")
                    {
                        scoreSimeon += pointsAttempted2;

                        if (scoreSimeon > 500)
                        {
                            scoreSimeon -= pointsAttempted2;
                        }
                        if (scoreSimeon == 500)
                        {
                            Console.WriteLine("Simeon");
                            Console.WriteLine(i);
                            Console.WriteLine(scoreNakov);
                            return;
                        }
                    }
                }
            }
            isSimeonFirst = !isSimeonFirst;
        }
        if (scoreSimeon == scoreNakov)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(scoreNakov);
        }
        if (scoreNakov > scoreSimeon)
        {
            Console.WriteLine("Nakov");
            Console.WriteLine(scoreNakov - scoreSimeon);
        }
        if (scoreNakov < scoreSimeon)
        {
            Console.WriteLine("Simeon");
            Console.WriteLine(scoreSimeon - scoreNakov);
        }
    }
}