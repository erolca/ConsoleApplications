using System;

class MainClass
{
    static void Main()
    {
        const int count = 5;

        for (int i = 0, j = 10; i < count; i++, j += 10)
        {
            Console.WriteLine("{0}, {1}", i, j);
        }
    }
}