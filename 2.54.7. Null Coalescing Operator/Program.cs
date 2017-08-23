using System;

class MainClass
{
    static void Main()
    {
        int? nullableInteger = null;
        Console.WriteLine("nullableInteger: {0}", nullableInteger ?? -1);

        nullableInteger = 10;
        Console.WriteLine("nullableInteger: {0}", nullableInteger ?? -1);
    }
}