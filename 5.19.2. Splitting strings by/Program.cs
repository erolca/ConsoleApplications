using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;


//5.19.2.	Splitting strings by |

public class MainClass
{
    public static void Main()
    {
        string s = "J|M|P|C";
        string[] pieces = s.Split('|');
        foreach (string piece in pieces)
        {
            Console.WriteLine(piece);
        }
    }
}

/*
J
M
P
C
*/
