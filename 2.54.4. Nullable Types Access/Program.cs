using System;

class MainClass
{
    static void Main()
    {
       // Explicitly use properties
        int? nullableInteger = 15;

        if (nullableInteger.HasValue)
            Console.WriteLine("{0}", nullableInteger.Value);

        // shortcut syntax
        if (nullableInteger != null)
            Console.WriteLine("{0}", nullableInteger);
    }
}