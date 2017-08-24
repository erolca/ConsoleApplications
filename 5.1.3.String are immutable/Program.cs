using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        // Set initial string value.
        string s1 = "This is my string.";
        Console.WriteLine("s1 = {0}", s1);

        // Uppercase the s1?
        string upperString = s1.ToUpper();
        Console.WriteLine("upperString = {0}", upperString);

        // Nope!  s1 is in the same format!
        Console.WriteLine("s1 = {0}", s1);

        string s2 = "My other string";
        s2 = "New string value";
    }
}