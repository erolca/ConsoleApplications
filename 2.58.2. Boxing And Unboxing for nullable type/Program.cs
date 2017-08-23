using System;
using System.ComponentModel;

class MainClass
{
    static void Main()
    {
        Nullable<int> nullable = 5;

        object boxed = nullable;
        Console.WriteLine(boxed.GetType());

        nullable = (Nullable<int>)boxed;
        Console.WriteLine(nullable);

        nullable = new Nullable<int>();
        boxed = nullable;
        Console.WriteLine(boxed == null);

        nullable = (Nullable<int>)boxed;
        Console.WriteLine(nullable.HasValue);
    }
}