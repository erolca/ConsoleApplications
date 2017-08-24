using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "ABCDEabcde1234567890";

        Console.WriteLine("Display str1, one char at a time.");
        for (int i = 0; i < str1.Length; i++)
            Console.Write(str1[i]);
        Console.WriteLine("\n");
    }
}