using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        Console.Write("Please, enter your birthday: ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        System.TimeSpan ageNow = currentDate - birthday;
        double yourAge = ageNow.TotalDays / 365.25;
        Console.WriteLine("Your age now is: " + ((int)yourAge));
        Console.WriteLine("Your age after 10 years will be: " + ((int)yourAge + 10));
    }
}
