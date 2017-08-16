using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

public class MainClass
{
    public static void Main()
    {
        int? x1 = null;
        int? x2 = new int?();
        int? y1 = 55;
        int? y2 = new int?(55);

        Console.WriteLine("{0}...{1}...{2}...{3}", x1, x2, y1, y2);

        Console.WriteLine("x1 == null? {0}", x1 == null);
        object x1o = x1;
        Console.WriteLine("x1o == null? {0}", x1o == null);

        Console.WriteLine("{0}...{1}", x1.GetType(), x1o.GetType());
    }

}