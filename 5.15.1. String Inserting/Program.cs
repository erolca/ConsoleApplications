using System;

class MainClass
{
    public static void Main()
    {
        string str = "This test";

        Console.WriteLine("Original string: " + str);

        // Insert 
        str = str.Insert(5, "is a ");
        Console.WriteLine(str);

    }
}