using System;

class MainClass
{
    public static void Main()
    {
        string str = "test";

        Console.WriteLine("Original string: " + str);

        // Pad on left with spaces. 
        str = str.PadLeft(10);
        Console.WriteLine("|" + str + "|");

        // Pad on right with spaces. 
        str = str.PadRight(20);
        Console.WriteLine("|" + str + "|");

    }
}
/*
 * Original string: test
|      test|
|      test          |

    */