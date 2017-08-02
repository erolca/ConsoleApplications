using System;

class MainClass
{
    static void Main(string[] args)
    {
        int MyInt = 12345;
        long MyLong = MyInt;
        short MyShort = (short)MyInt;


        /*2.15.1.	Boxing short*/
        short s = 25;
        Console.WriteLine("short s = {0}", s);
        Console.WriteLine("short is a: {0}", s.GetType().ToString());


        /*2.15.2.	Box the value type into a reference type*/
         s = 25;
        object objShort = s;
        short anotherShort = (short)objShort;
        Console.WriteLine("short anotherShort = {0}", anotherShort);
        Console.WriteLine("Boxed object is a: {0}", objShort.GetType().ToString());
    }
}
 
 