using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class MainClass
{

    public static void Main()
    {

        int parsedQty = 0;
        try
        {
            parsedQty = int.Parse("123");
        }
        catch (FormatException)
        {
        }


        if (!int.TryParse("123", out parsedQty))
        {
        }
    }
}