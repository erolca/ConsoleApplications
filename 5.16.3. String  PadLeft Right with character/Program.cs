using System;

class MainClass
{
    public static void Main()
    {
        string str = "     test    ";

        Console.WriteLine("Original string:" + str + "<");

        // Pad on left with #s. 
        str = str.PadLeft(10, '#');
        Console.WriteLine("|" + str + "|");

        // Pad on right with #s. 
        str = str.PadRight(20, '#');
        Console.WriteLine("|" + str + "|");

    }
}