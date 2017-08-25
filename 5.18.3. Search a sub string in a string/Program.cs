using System;

class MainClass
{
    public static void Main()
    {
        string str = "abcdefghijk";
        int idx;


        idx = str.IndexOf("def");
        Console.WriteLine("Index of first \"def\": " + idx);
    }
}

//Index of first "def": 3
