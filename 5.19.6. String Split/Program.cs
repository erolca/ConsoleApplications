using System;

public class MainClass
{
    static void Main()
    {
        string s1 = "One,Two,Three Associates, Inc.";
        const char Space = ' ';
        const char Comma = ',';
        char[] delimiters = new char[] { Space, Comma };
        foreach (string subString in s1.Split(delimiters))
        {
            Console.WriteLine(subString);
        }

    }
}