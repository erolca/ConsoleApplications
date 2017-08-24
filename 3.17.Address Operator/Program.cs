using System;

class TwoDimension
{
    int x, y;

    public TwoDimension()
    {
        x = y = 0;
    }
    public TwoDimension(int i, int j)
    {
        x = i;
        y = j;
    }

    // Overload &.   
    public static bool operator &(TwoDimension op1, TwoDimension op2)
    {
        if (((op1.x != 0) && (op1.y != 0)) & ((op2.x != 0) && (op2.y != 0)))
            return true;
        else
            return false;
    }

    // Show X, Y
    public void show()
    {
        Console.WriteLine(x + ", " + y);
    }
}

class MainClass
{
    public static void Main()
    {
        TwoDimension a = new TwoDimension(5, 6);
        TwoDimension b = new TwoDimension(10, 10);
        TwoDimension c = new TwoDimension(0, 0);

        Console.Write("Here is a: ");
        a.show();
        Console.Write("Here is b: ");
        b.show();
        Console.Write("Here is c: ");
        c.show();
        Console.WriteLine();

        if (a & b)
            Console.WriteLine("a & b is true.");
        else
            Console.WriteLine("a & b is false.");

        if (a & c)
            Console.WriteLine("a & c is true.");
        else
            Console.WriteLine("a & c is false.");
    }
}