using System;

class Problem08
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        bool prime = true;

        if (n == 1 || n == 0 || n < 0)
        {
            prime = false;
        }
        else
        { 
        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
            {
                prime = false;
                break;
            }
        }
        }

        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}", "x", "Prime?");
        Console.WriteLine("{0,-10}{1,-10}", n, prime);
    }
}

