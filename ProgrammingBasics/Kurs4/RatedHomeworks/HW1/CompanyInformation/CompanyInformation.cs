using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Write in the company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Write in the company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Write in your phone number: +359");
            ulong phoneNumber = ulong.Parse(Console.ReadLine());

            Console.Write("Write in fax number, or press 0 to leave empty \n fax number: ");
            ulong faxNumber = ulong.Parse(Console.ReadLine());

            Console.Write("Write in web address, or press 0 to leave empty \n web address: ");
            string webAddress = Console.ReadLine();

            Console.Write("Write in your manager's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Write in your manager's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Write in the manager's age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Company name: " + companyName + "\nCompany Address: " + companyAddress +
                "\nPhone number: +359" + phoneNumber + "\nWrite in fax number: " + faxNumber +
                "\nWeb Address: " + webAddress + "\nManager's first name: " + firstName +
                "\nManager's last name: " + lastName + "\nManagers age: " + age);

        }
    }
}
