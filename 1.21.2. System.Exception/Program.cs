using System;

public class Starter
{
    public static void Main()
    {
        try
        {
            int var1 = 5, var2 = 0;
            var1 /= var2;    // exception occurs
        }
        catch (Exception except)
        {
            if (except is SystemException)
            {
                Console.WriteLine("Exception thrown by runtime");
            }
            else
            {
                Console.WriteLine("Exception thrown by application");
            }
        }
    }
}