using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        string s = "Hello, World.";

        char[] c1 = s.ToCharArray();
        char[] c2 = s.ToCharArray(0, 5);
    }

}