using System;

class MainClass
{
    static void Main()
    {
        int? nullableInteger1, nullableInteger2, nullableInteger3;

        nullableInteger1 = 28;
        nullableInteger2 = nullableInteger1;
        nullableInteger3 = null;

        Console.WriteLine("nullableInteger1: {0}, nullableInteger2: {1}", nullableInteger1, nullableInteger2);
        Console.WriteLine("nullableInteger3 {0} null", nullableInteger3 == null ? "is" : "is not");
    }
}