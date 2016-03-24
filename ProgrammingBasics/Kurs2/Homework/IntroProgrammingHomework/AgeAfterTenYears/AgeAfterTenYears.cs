using System;
class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        // Console.WriteLine("Birthday: " + birthday);
        DateTime today = new DateTime(2015, 11, 1); //.Today; 
        // Console.WriteLine("Today is: " + today);

        //tests
        //TimeSpan age = today - birthday;
        //Console.WriteLine(age);
        //int AGE = age.Days;
        //Console.WriteLine(AGE);

        int dayOfBirth = birthday.Day;
        int monthOfBirth = birthday.Month;
        int yearOfBirth = birthday.Year;
        int dayOfToday = today.Day;
        int monthOfToday = today.Month;
        int yearOfToday = today.Year;
        int age = 0;
        if (dayOfBirth == dayOfToday && monthOfBirth == monthOfToday)
        {
            age = yearOfToday - yearOfBirth;
        }
        if ((monthOfBirth == monthOfToday && dayOfBirth > dayOfToday) || monthOfBirth > monthOfToday)
        {
            age = yearOfToday - yearOfBirth - 1;
        }
        else
        {
            age = yearOfToday - yearOfBirth;
        }
        Console.WriteLine("Now: " + age);
        Console.WriteLine("After 10 years: " + (age + 10));
    }
}

