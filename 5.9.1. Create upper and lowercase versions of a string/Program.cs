using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "ABCDEabcde1234567890";

        string strLow = str1.ToLower();
        string strUp = str1.ToUpper();
        Console.WriteLine("Lowercase version of str1:\n " + strLow);
        Console.WriteLine("Uppercase version of str1:\n " + strUp);
    }
}