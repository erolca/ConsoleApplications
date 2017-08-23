using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

class MainClass
{
    static void Main()
    {
        int? nullable = 5;

        object boxed = nullable;
        Console.WriteLine(boxed.GetType());

        int normal = (int)boxed;
        Console.WriteLine(normal);

        nullable = (int?)boxed;
        Console.WriteLine(nullable);

        nullable = new int?();
        boxed = nullable;
        Console.WriteLine(boxed == null);

        nullable = (int?)boxed;
        Console.WriteLine(nullable.HasValue);
    }
}