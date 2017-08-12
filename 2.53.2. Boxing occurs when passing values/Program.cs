using System;

class MainClass
{
    public static void Main()
    {
        int x;

        x = 10;
        Console.WriteLine("Here is x: " + x);

        // x is automatically boxed when passed to sqr() 
        x = sqr(x);
        Console.WriteLine("Here is x squared: " + x);
    }

    static int sqr(object o)
    {
        return (int)o * (int)o;
    }
}