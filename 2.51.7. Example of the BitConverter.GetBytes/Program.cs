using System;

class GetBytesUInt32Demo
{
    const string formatter = "{0,16}{1,20}";

    public static void GetBytesUInt32(uint argument)
    {
        byte[] byteArray = BitConverter.GetBytes(argument);
        Console.WriteLine(formatter, argument, BitConverter.ToString(byteArray));
    }

    public static void Main()
    {
        GetBytesUInt32(15);
        GetBytesUInt32(25);
    }
}