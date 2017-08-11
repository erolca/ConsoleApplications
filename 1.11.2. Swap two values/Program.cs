using System;

class Swap
{
    // This method now changes its arguments. 
    public void swap(ref int a, ref int b)
    {
        int t;

        t = a;
        a = b;
        b = t;
    }
}

class MainClass
{
    public static void Main()
    {
        Swap ob = new Swap();

        int x = 10, y = 20;

        Console.WriteLine("x and y before call: " + x + " " + y);

        ob.swap(ref x, ref y);

        Console.WriteLine("x and y after call: " + x + " " + y);
    }
}