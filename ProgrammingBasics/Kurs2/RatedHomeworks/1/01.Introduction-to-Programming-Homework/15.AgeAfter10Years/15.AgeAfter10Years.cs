using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthday in format(dd.mm.yyyy):");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        long resulut = DateTime.Today.Subtract(userBirthday).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
    }
}
