using System;

struct Point
{
    public int x;
    public int y;

    public Point(int xVal, int yVal)
    {
        x = xVal;
        y = yVal;
    }
}

class MainClass
{
    static void Main()
    {
        Point p = new Point(6, 11);
        Point? nullablePoint = new Point(5, 10);

        Console.WriteLine("p.x: {0}", p.x);
        Console.WriteLine("p.y: {0}", p.y);

        Console.WriteLine("nullablePoint.x: {0}", nullablePoint.Value.x);
        Console.WriteLine("nullablePoint.y: {0}", nullablePoint.Value.y);
    }

}