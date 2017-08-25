using System;

class MainClass
{
    public static void Main()
    {
        string str = "This is a test";

        Console.WriteLine("Original string: " + str);

        // Remove 
        str = str.Remove(4, 5);
        Console.WriteLine(str);
    }
}