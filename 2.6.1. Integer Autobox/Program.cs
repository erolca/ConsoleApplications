using System;

class MainClass
{
    public static void Main()
    {
        Console.WriteLine(5.ToString());


        /*2.6.2.	Box int to object and unbox it back*/
        int v = 55;
        object o = v;        // box v into o
        Console.WriteLine("Value is: {0}", o);
        int v2 = (int)o;    // unbox back to an int

        /*2.6.3.	implicit boxing from i to object*/
        int i = 123;
        object ox = i;  // implicit boxing

        i = 456;  // change the contents of i

        System.Console.WriteLine("The value-type value = {0}", i);
        System.Console.WriteLine("The object-type value = {0}", ox);


    }
}
 
 