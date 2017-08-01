using System;
using System.ComponentModel;

class DefaultValueComparison
{
    static int CompareToDefault<T>(T value)
        where T : IComparable<T>
    {
        return value.CompareTo(default(T));
    }

    static int CCS<A>(A val)
        where A : IComparable<A>
    {


        return val.CompareTo(default(A));
    }

    static void Main()
    {
        Console.WriteLine(CompareToDefault("x"));
        Console.WriteLine(CompareToDefault(10));
        Console.WriteLine(CompareToDefault(0));
        Console.WriteLine(CompareToDefault(-10));
        Console.WriteLine(CompareToDefault(DateTime.MinValue));
        int nint=25;
        
        System.Console.WriteLine(nint.ToString());

        Boolean a1 = true, a2 = true;


        Console.WriteLine(a1.CompareTo(a2));
        Console.WriteLine(a1.CompareTo((Object)a2));

    }
}