using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "ABCDEabcde1234567890";
        string str3 = "C# strings are powerful.";


        int result = str1.CompareTo(str3);
        if (result == 0)
            Console.WriteLine("str1 and str3 are equal");
        else if (result < 0)
            Console.WriteLine("str1 is less than str3");
        else
            Console.WriteLine("str1 is greater than str3");

    }
}