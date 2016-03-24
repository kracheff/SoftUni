using System;

class Integers
{
    static void Main()
    {
        sbyte signedByte = -100;
        byte unsignedByte = 128;
        short signedShort = -3540;
        ushort unsignedShort = 64876;
        uint unsignedInt = 2147483648;
        int signedInt = -1141583228;
        long signedLong = -1223372036854775808;
        Console.WriteLine(signedByte);
        Console.WriteLine(unsignedByte);
        Console.WriteLine(signedShort);
        Console.WriteLine(unsignedShort);
        Console.WriteLine(unsignedInt);
        Console.WriteLine(signedInt);
        Console.WriteLine(signedLong);
    }
}