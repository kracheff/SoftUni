using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 3;
        int b = -3;
        Console.WriteLine("Before" + "\n" + "a = " + a + "\n" + "b = " + b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

