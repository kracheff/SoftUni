using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNull = null;
        double? secondNull = null;
        Console.WriteLine(firstNull + "\n" + secondNull);

        int? firstTest = firstNull + 5;
        int? secondTest = firstNull + null;
        double? thirdTest = secondNull + 3.14;
        double? fourthTest = secondNull + null;
        Console.WriteLine(firstTest + "\n" + secondTest + "\n" + thirdTest + "\n" + fourthTest);
    }
}

