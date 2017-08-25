using System;

class MainClass
{
    public static void Main()
    {
        string str = "abcdefghijk";
        int idx;

        Console.WriteLine("str: " + str);

        idx = str.LastIndexOf('h');
        Console.WriteLine("Index of last 'h': " + idx);

    }
}