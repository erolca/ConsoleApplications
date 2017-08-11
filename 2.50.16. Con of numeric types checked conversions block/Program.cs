using System;

class MainClass
{
    public static void Main()
    {
        checked
        {
            uint value1 = 312;
            byte value2 = (byte)value1;
            Console.WriteLine("Value: {0}", value2);
        }
    }
}