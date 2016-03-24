using System;
class FourDigitNumber
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());

        byte firstNumber = (byte)(number / 1000);
        byte secondNumber = (byte)((number / 100) % 10);
        byte thirdNumber = (byte)((number / 10) % 10);
        byte fourtNumber = (byte)(number % 10);

        string numToString = number.ToString();
        char firstElement = numToString[0];
        char secondElement = numToString[1];
        char thirdElement = numToString[2];
        char fourthElement = numToString[3];

        int sumOfDigits = firstNumber + secondNumber + thirdNumber + fourtNumber;
        string reversed = "" + fourthElement + thirdElement + secondElement + firstElement;
        string lastFirst = "" + fourthElement + firstElement + secondElement + thirdElement;
        string secondThird = "" + firstElement + thirdElement + secondElement + fourthElement;

        // formatting the result to look better

        string rowName1 = "Sum of digits: ";
        string rowName2 = "Reversed: ";
        string rowName3 = "Last digit in front: ";
        string rowName4 = "Second and third digits exchanged: ";

        Console.WriteLine("|{0, -40}|{1, -10}|", rowName1, sumOfDigits);
        Console.WriteLine("|{0, -40}|{1, -10}|", rowName2, reversed);
        Console.WriteLine("|{0, -40}|{1, -10}|", rowName3, lastFirst);
        Console.WriteLine("|{0, -40}|{1, -10}|", rowName4, secondThird);
        Console.WriteLine();
    }
}
