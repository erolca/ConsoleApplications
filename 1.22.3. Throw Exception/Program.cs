using System;

class MainClass
{

    static void AFunction()
    {
        int Zero = 0;
        int j = 22 / Zero;
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("efore Function");
            AFunction();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("DivideByZero {0}", e);
        }
    }
}