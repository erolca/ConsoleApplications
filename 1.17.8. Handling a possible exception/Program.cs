using System;
class MainClass
{
    public static int AnExceptionFunction(int value)
    {
        if (value == 0) // Can't divide by zero
            throw new DivideByZeroException("Divide By 0 error!");

        int x = 20 / value;
        return x;
    }

    public static void Main()
    {
        int value = 0;
        try
        {
            value = AnExceptionFunction(10); // This works ok
            Console.WriteLine("Value = {0}", value);
            AnExceptionFunction(0); // This doesn't
            Console.WriteLine("Value = {0}", value);
        }
        catch (Exception e)
        {
            Console.WriteLine("Caught an exception {0}. Continuing", e);
        }
        Console.WriteLine("Done");


        int[] numer = { 4, 8, 16 };
        int j = 0;

        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.WriteLine(numer[i] + " / " +
                                   numer[i] + " is " +
                                   numer[i] / j);
            }
            catch (DivideByZeroException)
            {
                // catch the exception 
                Console.WriteLine("Can't divide by Zero!");
            }
            catch (IndexOutOfRangeException)
            {
                // catch the exception 
                Console.WriteLine("No matching element found.");
            }
        }






        try
        {
            throw new Exception(); // İstisna oluşur fakat herhangi bir özel mesaj yoktur.

        }
        catch (Exception e)
        {

            throw new Exception("Hata Meydana Geldi", e); // Hata mesajı ile birlikte dışardan oluşan hata sınıfa gönderilir. 

        }


    }
}