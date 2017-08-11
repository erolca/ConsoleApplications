using System;

class Class1
{
    static void Main(string[] args)
    {
        int x, m, b;
        double xd, md, bd;
        m = 2;
        md = 2.1;

        x = 3;
        xd = 4;

        b = 5;
        bd = 6.5;

        Console.WriteLine("int version of CalcY returns: {0}", IntFindY(m, x, b));
        Console.WriteLine("double version of FindY returns: {0}", DoubleFindY(md, xd, bd));
        Console.WriteLine("int version using doubles returns: {0}", IntFindY((int)md, (int)xd, (int)bd));
        Console.WriteLine("double version using ints returns: {0}", DoubleFindY(m, x, b));
    }

    static int IntFindY(int m, int x, int b)
    {
        return (m * x) + b;
    }

    static double DoubleFindY(double m, double x, double b)
    {
        return (m * x) + b;
    }
}