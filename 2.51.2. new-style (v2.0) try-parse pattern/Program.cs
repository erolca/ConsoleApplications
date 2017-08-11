using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;


public class MainClass
{
    public static void Main()
    {

        string s = "bad format";
        int i;
        if (int.TryParse(s, out i))
        {
            // Use 'i'
        }
        else
        {
            // Handle the error; e.g. tell the user input was invalid.
            Console.WriteLine("Input invalid");
        }
    }
}