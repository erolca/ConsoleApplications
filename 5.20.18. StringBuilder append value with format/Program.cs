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
        StringBuilder sb = new StringBuilder("Foo");
        sb.AppendFormat("...{0}", DateTime.Now);

        string final = sb.ToString();
        Console.WriteLine(final);
    }
}