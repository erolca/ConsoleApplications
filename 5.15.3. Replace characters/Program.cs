using System;

class MainClass
{
    public static void Main()
    {
        string str = "This is a test";

        Console.WriteLine("Original string: " + str);

        // Replace characters 
        str = str.Replace('a', 'X');
        Console.WriteLine(str);

    }
}

/*Original string: This is a test
This is X test
*/