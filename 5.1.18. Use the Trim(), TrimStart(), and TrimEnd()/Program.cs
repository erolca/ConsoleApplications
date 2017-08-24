using System;

class MainClass
{

    public static void Main()
    {

        string myString18 = '(' + "  Whitespace  ".Trim() + ')';
        Console.WriteLine("'(' + \"  Whitespace  \".Trim() + ')' = " + myString18);
        string myString19 = '(' + "  Whitespace  ".TrimStart() + ')';
        Console.WriteLine("'(' + \"  Whitespace  \".TrimStart() + ')' = " + myString19);
        string myString20 = '(' + "  Whitespace  ".TrimEnd() + ')';
        Console.WriteLine("'(' + \"  Whitespace  \".TrimEnd() + ')' = " + myString20);

    }

}