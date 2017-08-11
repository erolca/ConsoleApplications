using System;

class Example
{
    public static void Main()
    {
        double n;

        for (n = 1.0; n <= 10; n++)
        {
            Console.WriteLine("The square root of {0} is {1}",
                              n, Math.Sqrt(n));

            Console.WriteLine("Whole number part: {0}",
                              (int)Math.Sqrt(n));

            Console.WriteLine("Fractional part: {0}",
                              Math.Sqrt(n) - (int)Math.Sqrt(n));
            Console.WriteLine();
        }
    }
}