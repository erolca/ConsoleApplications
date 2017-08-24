using System;

public class MainClass
{
    public static void Main()
    {
        double epsilon = 1.0e-9;
        double guess = 11.0;
        double result = 0.0;

        double value = 2;

        result = ((value / guess) + guess) / 2;

        do
        {
            Console.WriteLine("Guess Value  = {0}", guess);
            Console.WriteLine("Result Value = {0}", result);
            guess = result;
            result = ((value / guess) + guess) / 2;
        } while (Math.Abs(result - guess) > epsilon);
        Console.WriteLine("The approx sqrt of {0} is {1}", value, result);
    }
}