using System;

class MainClass
{
    static void Main(string[] args)
    {
        string strOriginal = "Original String";
        Console.WriteLine("Value of strOriginal before call: {0}", strOriginal);

        TryToAlterString(strOriginal);

        Console.WriteLine("Value of strOriginal after call: {0}", strOriginal);
    }

    static void TryToAlterString(string str)
    {
        str = "Modified String";
    }
}