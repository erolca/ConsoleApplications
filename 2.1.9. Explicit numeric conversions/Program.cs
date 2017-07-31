using System;

class MainClass
{
    public static void Main()
    {
        uint value1 = 312;
        byte value2 = (byte)value1;
        Console.WriteLine("Value2: {0}", value2);

        //	2.1.10.	Convert numeric types explicit to 'smaller' types

        // all implicit
        sbyte v = 55;
        short v2 = v;
        int v3 = v2;
        long v4 = v3;

        // explicit to "smaller" types
        v3 = (int)v4;
        v2 = (short)v3;
        v = (sbyte)v2;
    }
}