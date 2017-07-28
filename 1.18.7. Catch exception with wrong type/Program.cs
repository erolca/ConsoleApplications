using System;

class MainClass
{

    static void AFunction()
    {

        try
        {
            int Zero = 0;
            int j = 22 / Zero;
        }
        catch (ArgumentOutOfRangeException e) // this exception doesn't match
        {
            Console.WriteLine("OutOfRangeException: {0}", e);
        }
        Console.WriteLine("In AFunction()");
    }
    public static void Main()
    {
        try
        {
            AFunction();
        }
        // this exception doesn't match
        catch (ArgumentException e)
        {
            Console.WriteLine("ArgumentException {0}", e);
        }
        catch (Exception ee)
        {
            Console.WriteLine("Exception {0}", ee);
        }
      
    }
}