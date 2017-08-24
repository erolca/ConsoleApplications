using System;

class MainClass
{
    private static string MakeLine(int initVal, int multVal, string sep)
    {

        string[] sArr = new string[10];

        for (int i = initVal; i < initVal + 10; i++)
            sArr[i - initVal] = String.Format("{0,-3}", i * multVal);

        return (String.Join(sep, sArr));
    }

    public static void Main()
    {

        string[] myStrings = { "To", "be", "or", "not", "to", "be" };
        string myString9 = String.Join(".", myStrings);
        Console.WriteLine("myString9 = " + myString9);
        Console.WriteLine();

        Console.WriteLine(MakeLine(0, 5, ", "));
        Console.WriteLine(MakeLine(1, 6, "  "));
        Console.WriteLine(MakeLine(9, 9, ": "));
        Console.WriteLine(MakeLine(4, 7, "< "));
    }

}