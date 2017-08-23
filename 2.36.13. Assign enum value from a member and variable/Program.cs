using System;

enum Color
{
    Green,
    Yellow,
    Red
}

class MainClass
{
    static void Main()
    {
        Color t1 = Color.Red;
        Color t2 = Color.Green;
        Color t3 = t2;

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
    }
}