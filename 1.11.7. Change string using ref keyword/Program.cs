using System;

class MainClass
{
    public static void UpperCaseThisString(ref string s)
    {
        s = s.ToUpper();
    }
    public static void Main()
    {
        string s = "str";
        Console.WriteLine("-> Before: {0}", s);
        UpperCaseThisString(ref s);
        Console.WriteLine("-> After: {0}\n", s);
    }
}