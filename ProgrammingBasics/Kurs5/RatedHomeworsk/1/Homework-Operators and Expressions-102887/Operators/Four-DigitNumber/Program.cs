using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Four_DigitNumber
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());

        //fourth digit
        int firstDigit = number % 10;

        //third digit
        int restNumberTwo = number / 10;
        int secondDigit = restNumberTwo % 10;

        //second digit
        int restNumberThree = number / 100;
        int thirdDigit = restNumberThree % 10;

        //first digit
        int restNumberFour = number / 1000;
        int fourthDigit = restNumberFour % 10;

        Console.WriteLine("Number = " + number);
        Console.WriteLine("Sum of digits = " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
        Console.WriteLine("Reversed = {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Last digit in front = {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
        Console.WriteLine("Second and third digits exchanged = {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
    }    
}