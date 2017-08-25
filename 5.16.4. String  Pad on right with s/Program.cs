using System;

class MainClass
{
    public static void Main()
    {
        string str = "     test    ";

        Console.WriteLine("Original string:" + str + "<");
        // Pad on right with #s. 
        str = str.PadRight(20, '#');
        Console.WriteLine("|" + str + "|");

        // Trim #s. 
        str = str.Trim('#');
        Console.WriteLine("|" + str + "|");
    }
}

/*
 * Original string:     test    <
|     test    #######|
|     test    |

    */