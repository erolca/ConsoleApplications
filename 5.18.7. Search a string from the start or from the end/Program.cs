using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "ABCDEabcde1234567e890";

        // search string 
        int idx = str1.IndexOf("e");
        Console.WriteLine("Index of first occurrence of One: " + idx);
        idx = str1.LastIndexOf("e");
        Console.WriteLine("Index of last occurrence of One: " + idx);

    }
}