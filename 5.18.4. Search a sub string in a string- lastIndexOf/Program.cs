using System;

class MainClass
{
    public static void Main()
    {
        string str = "abcdefghijk";
        int idx;

        idx = str.LastIndexOf("def");
        Console.WriteLine("Index of last \"def\": " + idx);
    }
}