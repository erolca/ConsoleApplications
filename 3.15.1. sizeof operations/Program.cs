using System;
using System.Globalization;

struct MyValueType
{
    public short s;
    public int i;
    public long l;
}


public class MainClass
{

    static void Main(string[] args)
    {
        Console.WriteLine("sizeof operations");
        unsafe
        {
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of long is {0}", sizeof(long));
            Console.WriteLine("The size of MyValueType is {0}\n", sizeof(MyValueType));
        }
    }
}