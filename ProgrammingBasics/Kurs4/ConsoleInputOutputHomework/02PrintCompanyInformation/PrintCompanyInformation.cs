using System;
class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine(); //0
        string companyAddress = Console.ReadLine(); //1
        string phoneNumber = Console.ReadLine(); //2 // it is a string because no calculations will be performed with this number
        string faxNumber = Console.ReadLine(); //3
        string webSite = Console.ReadLine(); //4
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb Site: {4}\nManager: {5}", 
            companyName, 
            companyAddress, 
            phoneNumber,
            faxNumber,
            webSite,
            managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhone + ")");
    }
}

