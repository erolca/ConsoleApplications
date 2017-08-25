using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        bool b1 = "hello" == "hello";
        Console.WriteLine(b1);
        bool b2 = "hello" == "hi";
        Console.WriteLine(b2);
        bool b3 = "hello".Equals("hello");
        Console.WriteLine(b3);
        bool b4 = "hello".Equals("hi");
        Console.WriteLine(b4);
        bool b5 = "HoWdY".Equals("howdy");
        Console.WriteLine(b5);
        bool b6 = "HoWdY".Equals("howdy", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(b6);
    }

}