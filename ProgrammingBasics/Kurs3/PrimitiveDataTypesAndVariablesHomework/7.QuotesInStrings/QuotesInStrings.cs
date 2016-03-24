using System;
class QuotesInStrings
{
    static void Main()
    {
        string firstWay = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstWay);
        string secondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(secondWay);
    }
}

