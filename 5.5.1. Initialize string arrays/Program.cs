using System;

class MainClass
{
    public static void Main()
    {
        string[] stringArray = { "Hello", "World" };
        foreach (string myString in stringArray)
        {
            Console.WriteLine("myString = " + myString);
        }
    }
}