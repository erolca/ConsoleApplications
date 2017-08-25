using System;

class MainClass
{
    public static void Main()
    {
        string str = "abcdefghijk";

        if (str.StartsWith("abc"))
            Console.WriteLine("str begins with \"abc\"");

        if (str.EndsWith("ijk"))
            Console.WriteLine("str ends with \"ijk.\"");
    }
}