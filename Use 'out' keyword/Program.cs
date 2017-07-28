using System;

class MainClass
{
    class Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void GetPoint(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }

        int x;
        int y;
    }



    public static void Add(int x, int y, out int ans)
    {
        ans = x + y;
    }

    public static void Main()
    {

        Console.WriteLine("Adding 2 ints using out keyword");
        int ans=5;
        Add(90, 90, out ans);
        Console.WriteLine("90 + 90 = {0}\n", ans);


        Point myPoint = new Point(10, 15);
        int x;
        int y;

        myPoint.GetPoint(out x, out y);
        Console.WriteLine("myPoint({0}, {1})", x, y);


    }
}
