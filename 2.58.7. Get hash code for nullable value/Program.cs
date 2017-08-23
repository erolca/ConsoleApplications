using System;
using System.ComponentModel;

class NullableMembers
{
    static void Display(Nullable<int> x)
    {
        Console.WriteLine("HasValue: {0}", x.HasValue);
        if (x.HasValue)
        {
            Console.WriteLine("Value: {0}", x.Value);
            Console.WriteLine("Explicit conversion: {0}", (int)x);
        }
        Console.WriteLine("GetHashCode(): {0}", x.GetHashCode());
    }

    static void Main()
    {
        Nullable<int> x = 5;
        x = new Nullable<int>(5);
        Console.WriteLine("Instance with value:");
        Display(x);

        x = new Nullable<int>();
        Console.WriteLine("Instance without value:");
        Display(x);
    }
}