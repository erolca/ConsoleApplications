using System;

class MainClass
{
    public static void Main()
    {
        string str = "abcdefghijk";
        int idx;

        char[] chrs = { 'a', 'b', 'c' };
        idx = str.IndexOfAny(chrs);
        Console.WriteLine("Index of first 'a', 'b', or 'c': " + idx);
    }
}