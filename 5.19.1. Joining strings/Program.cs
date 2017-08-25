using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Security.Cryptography;

public class MainClass
{
    public static void Main()
    {
        string[] s = new string[] { "J", "M", "P", "C" };
        string joined = String.Join("|", s);
        Console.WriteLine(joined);
    }
}