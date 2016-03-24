using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long fibo1 = 0;
        long fibo2 = 1;
        Console.Write("{0} {1} ", fibo1, fibo2);
        for (int i = 1; i <= n-2; i++)
        {
            long fiboNext = fibo2 + fibo1;
            Console.Write(fiboNext + " ");
            fibo1 = fibo2;
            fibo2 = fiboNext;
        }
    }
}
