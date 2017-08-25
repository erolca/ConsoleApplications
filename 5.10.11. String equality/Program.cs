using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello!";
        string s2 = "Yo!";
        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}", s2);
        Console.WriteLine();

        Console.WriteLine("s1 == s2: {0}", s1 == s2);
        Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
        Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
        Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
        Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
        Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
    }
}