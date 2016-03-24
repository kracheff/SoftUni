using System;



class NumbersNotDivisibleBy_3And7
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i += 1)
        {
            if ((i % 3 == 0) || (i % 7 == 0))
            {
                continue;


            }
            Console.Write(i + " ");
            
        }
    }
}


