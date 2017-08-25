using System;
using System.Globalization;


public class SamplesTextInfo
{

    public static void Main()
    {
        string myString = "this Is a Test";

        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        Console.WriteLine("\"{0}\" to lowercase: {1}", myString, myTI.ToLower(myString));

        Console.WriteLine("\"{0}\" to uppercase: {1}", myString, myTI.ToUpper(myString));

        Console.WriteLine("\"{0}\" to titlecase: {1}", myString, myTI.ToTitleCase(myString));
    }
}