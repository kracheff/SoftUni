using System;
namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please chouse:");
            Console.WriteLine("1 ==> int");
            Console.WriteLine("2 ==> double");
            Console.WriteLine("3 ==> string");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.Write("please enter a integer: ");
                    int entint = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your integer is {0}", entint); break;
                case 2:
                    Console.Write("Enter your double: ");
                    double entdec = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", entdec + 1); break;
                case 3:
                    Console.Write("Enter string: ");
                    string entstr = Console.ReadLine();
                    Console.WriteLine("*{0}", entstr); break;
            }

        }
    }
}