using System;
    class Factorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);

    }
}
