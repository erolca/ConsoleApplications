using System;

class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Calling AccessInvalidArrayElement()");
        AccessInvalidArrayElement();

        try
        {
            Console.WriteLine("Calling DivideByZero()");
            DivideByZero();

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Handling an IndexOutOfRangeException");
            Console.WriteLine("Message = " + e.Message);
            Console.WriteLine("StackTrace = " + e.StackTrace);
        }
    }

    public static void AccessInvalidArrayElement()
    {
        int[] myArray = new int[2];
        try
        {
            Console.WriteLine("Attempting to access an invalid array element");
            myArray[20] = 1;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Handling an IndexOutOfRangeException");
            Console.WriteLine("Message = " + e.Message);
            Console.WriteLine("StackTrace = " + e.StackTrace);
        }
    }

    public static void DivideByZero()
    {
        int zero = 0;
        Console.WriteLine("Attempting division by zero");
        int myInt = 1 / zero;
    }

}