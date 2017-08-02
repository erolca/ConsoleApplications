using System;

public class MainClass
{
    static void Main()
    {
        int j = 123;
        object boxed = j;
        object obj = new Object();

        Console.WriteLine("boxed {0} int", boxed is int ? "is" : "isnot");
        Console.WriteLine("obj {0} int", obj is int ? "is" : "isnot");
        Console.WriteLine("boxed {0} System.ValueType", boxed is ValueType ? "is" : "isnot");

        /*
         * 2.4.5.A C# int is a shorthand for System.Int32, which inherits 
         * the following members from System.Object
         */

        Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
        Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
        Console.WriteLine("12.ToString() = {0}", 12.ToString());
        Console.WriteLine("12.GetType() = {0}", 12.GetType());

        /*	2.4.6.	Shifting an integer value*/
        int a = 1000;
        a >>= 4;
        Console.WriteLine(a);

    }
}
 
 