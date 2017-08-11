using System;
class RefExample2
{
    static void Method(ref string s)
    {
        s = "changed";
    }
    static void Main()
    {
        string str = "original";
        Method(ref str);
        Console.WriteLine(str);
    }
}