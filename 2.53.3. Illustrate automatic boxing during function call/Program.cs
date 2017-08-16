using System;
using System.Collections;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n***** Calling Foo() *****");
        int x = 99;
        Foo(x);
        Console.WriteLine(x.GetTypeCode());
    }
    public static void Foo(object o)
    {
        Console.WriteLine(o.GetType());
        
        Console.WriteLine(o.ToString());
        Console.WriteLine("Value of o is: {0}", o);

        // Need to unbox to get at members of
        // System.Int32.
        int unboxedInt = (int)o;
        Console.WriteLine(unboxedInt.GetTypeCode());
    }

}