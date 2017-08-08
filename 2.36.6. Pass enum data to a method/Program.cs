using System;


public enum LineStyle
{
    Solid,
    Dotted,
    DotDash,
}

enum Values
{
    A = 1,
    B = 5,
    C = 3,
    D = 42
}


class MainClass
{
    public static void Main()
    {
        /*2.36.7.	Assign int value to enumerations*/

        Values v = (Values)2;
        int ival = (int)v;


        DrawLine(LineStyle.Solid);
        DrawLine((LineStyle)35);
    }
    public static void DrawLine(LineStyle lineStyle)
    {
        switch (lineStyle)
        {
            case LineStyle.Solid:
                Console.WriteLine("draw solid");
                break;

            case LineStyle.Dotted:
                Console.WriteLine("draw dotted");
                break;

            case LineStyle.DotDash:
                Console.WriteLine("draw dotdash");
                break;

            default:
                throw (new ArgumentException("Invalid line style"));
        }
    }

}