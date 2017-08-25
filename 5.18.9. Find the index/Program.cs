using System;

class Sample
{
    public static void Main()
    {

        string str = "this is a test.";
        int start;
        int at;
        string target = "is";
        char[] anyOf = target.ToCharArray();

        start = str.Length - 1;
        at = str.LastIndexOfAny(anyOf);
        if (at > -1)
            Console.Write(at);
        else
            Console.Write("(not found)");
        Console.Write("{0}{0}{0}", Environment.NewLine);
    }
}