using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        string s1 = "    My     ";
        Console.WriteLine(s1);
        Console.WriteLine(s1.Trim());

        string s2 = "__...,, r!,..._";
        Console.WriteLine(s2);
        char[] trimChars = new char[] { '.', ',', '_' };
        Console.WriteLine(s2.Trim(trimChars));
        Console.WriteLine(s2.TrimStart(trimChars));
        Console.WriteLine(s2.TrimEnd(trimChars));
    }

}