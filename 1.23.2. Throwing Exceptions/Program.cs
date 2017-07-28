using System;

class MainClass
{
    static void Main()
    {
        string arg = null;

        try
        {
            if (arg == null)
            {
                ArgumentNullException MyEx = new ArgumentNullException();
                throw MyEx;
            }
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Message: {0}", e.Message);
        }
    }
}