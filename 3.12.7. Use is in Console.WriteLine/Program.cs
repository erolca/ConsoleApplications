using System;

public class MainClass
{
    static void Main()
    {
        String derivedObj = "Dummy";
        Object baseObj1 = new Object();
        Object baseObj2 = derivedObj;

        Console.WriteLine("baseObj2 {0} String", baseObj2 is String ? "is" : "isnot");
        Console.WriteLine("baseObj1 {0} String", baseObj1 is String ? "is" : "isnot");
        Console.WriteLine("derivedObj {0} Object", derivedObj is Object ? "is" : "isnot");

    }
}