using System;

class MainClass
{

    public static void Main()
    {

        int result;
        result = String.Compare("bbc", "abc");
        Console.WriteLine("String.Compare(\"bbc\", \"abc\") = " + result);
        result = String.Compare("abc", "bbc");
        Console.WriteLine("String.Compare(\"abc\", \"bbc\") = " + result);
        result = String.Compare("bbc", "bbc");
        Console.WriteLine("String.Compare(\"bbc\", \"bbc\") = " + result);
        result = String.Compare("bbc", "BBC", true);
        Console.WriteLine("String.Compare(\"bbc\", \"BBC\", true) = " + result);
        result = String.Compare("bbc", "BBC", false);
        Console.WriteLine("String.Compare(\"bbc\", \"BBC\", false) = " + result);
        result = String.Compare("Hello World", 6, "Goodbye World", 8, 5);
        Console.WriteLine("String.Compare(\"Hello World\", 6, " + "\"Goodbye World\", 8, 5) = " + result);

    }

}