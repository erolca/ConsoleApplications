using System;

class MainClass
{
    public static void Main()
    {
        int? count = null;

        if (count.HasValue)
            Console.WriteLine("count has this value: " + count.Value);
        else
            Console.WriteLine("count has no value");

        count = 100;

        if (count.HasValue)
            Console.WriteLine("count has this value: " + count.Value);
        else
            Console.WriteLine("count has no value");
    }
}