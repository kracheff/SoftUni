using System;

class EmployeeData
{
    static void Main()
    {
        string firstName;
        string lastName;
        byte age;
        char gender;
        string personalId; //Personal ID is string, not integer 
        //although it looks more like a number than text. This ID number may contain letters, not only digits in it
        //and no calculations are performed using this number even if it contains only digits.
        int employeeID;

        firstName = "Amanda";
        lastName = "Jonson";
        age = 27;
        gender = 'f';
        personalId = "8306112507";
        employeeID = 27563571;

        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",
            firstName, lastName, age, gender, personalId, employeeID);
    }
}

