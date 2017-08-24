using System;

public class ConcatTest
{
    public static void Main()
    {
        string[] s = { "hello ", "and ", "welcome ", "to ", "this ", "demo! " };

        Console.WriteLine(string.Concat(s));

        Array.Sort(s);
        Console.WriteLine(string.Concat(s));
    }
}