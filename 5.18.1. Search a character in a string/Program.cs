using System;

class MainClass
{
    public static void Main()
    {
        string str = "abcdefghijk";
        int idx;

        Console.WriteLine("str: " + str);

        idx = str.IndexOf('h');
        Console.WriteLine("Index of first 'h': " + idx);

    }
}