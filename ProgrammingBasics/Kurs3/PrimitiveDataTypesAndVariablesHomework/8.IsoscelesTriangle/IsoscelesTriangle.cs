using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9'; //The copyright symbol is no.169 in the unicode table
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copyRight);
    }
}

