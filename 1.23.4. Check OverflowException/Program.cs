using System;

class MainClass
{
    static void Main(string[] args)
    {
        int MyInt = 12345000;
        long MyLong = MyInt;

        try
        {
            long c = checked(MyLong * 5000000);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e);
        }

    }

}
