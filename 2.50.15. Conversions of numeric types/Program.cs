using System;

class MainClass
{
    public static void Main()
    {
        uint value1 = 999;
        byte value2;

        value2 = unchecked((byte)value1);    // never checked
        value2 = (byte)value1;            // checked if /checked
        value2 = checked((byte)value1);        // always checked
    }
}