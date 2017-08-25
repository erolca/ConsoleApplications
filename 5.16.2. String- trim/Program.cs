using System;

//string trim removes characters from the beginning and end of a string.
//Removes all leading and trailing white-space characters from the current String object.
class MainClass
{
    public static void Main()
    {
        string str = "     test    ";

        Console.WriteLine("Original string:" + str + "<");

        // Trim spaces. 
        str = str.Trim();
        Console.WriteLine("|" + str + "|");

    }
}

/*
 * Original string:     test    <
|test|
*/