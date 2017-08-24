using System;

class MainClass
{

    public static void Main()
    {
        string[] myStrings = { "To", "be", "or", "not", "to", "be" };
        string myString = String.Join(".", myStrings);

        string myString14 = '(' + myString.PadLeft(20) + ')';
        Console.WriteLine("'(' + myString.PadLeft(20) + ')' = " + myString14);
        string myString15 = '(' + myString.PadLeft(20, '.') + ')';
        Console.WriteLine("'(' + myString.PadLeft(20, '.') = " + myString15);
        string myString16 = '(' + myString.PadRight(20) + ')';
        Console.WriteLine("'(' + myString.PadRight(20) + ')' = " + myString16);
        string myString17 = '(' + myString.PadRight(20, '.') + ')';
        Console.WriteLine("'(' + myString.PadRight(20, '.') + ')' = " + myString17);

    }

}