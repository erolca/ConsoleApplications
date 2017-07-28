using System;

class MainClass
{
    public static void Main()
    {
        try
        {
            Exception myException = new Exception("myException");

            myException.HelpLink = "See the Readme.txt file";
            myException.Source = "My Program";
            throw myException;
        }
        catch (Exception e)
        {
            Console.WriteLine("HelpLink = " + e.HelpLink);
            Console.WriteLine("Message = " + e.Message);
            Console.WriteLine("Source = " + e.Source);
            Console.WriteLine("StackTrace = " + e.StackTrace);
            Console.WriteLine("TargetSite = " + e.TargetSite);
        }
    }
}