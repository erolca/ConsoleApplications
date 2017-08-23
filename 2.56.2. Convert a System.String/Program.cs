using System;

using System.Globalization;

class MainClass
{
    static void Main(string[] args)
    {
        string theString = "true";
        Console.WriteLine("Convert.ToBoolean(theString)");
        bool theBool = Convert.ToBoolean(theString);
        Console.WriteLine("Type code string converted to bool is: {0}", theBool.GetTypeCode());
        Console.WriteLine("Value of converted string: {0}", theBool);
    }
}