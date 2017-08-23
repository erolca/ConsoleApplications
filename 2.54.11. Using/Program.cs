using System;

class MainClass
{
    static double myMethod()
    {
        Console.WriteLine("In myMethod().");
        return 0.0;
    }

    public static void Main()
    {
        double? defaultValue = 1.5;
        double currentBalance;

        currentBalance = defaultValue ?? myMethod();
        Console.WriteLine(currentBalance);

        defaultValue = null;
        currentBalance = defaultValue ?? myMethod();
        Console.WriteLine(currentBalance);

    }
}