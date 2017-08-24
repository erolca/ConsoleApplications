using System;

class MainClass
{
    public static void Main()
    {
        int i;
        int sum = 0;

        // sum the numbers through 5  
        for (i = 1; i <= 5; sum += i++) ;

        Console.WriteLine("Sum is " + sum);
    }
}