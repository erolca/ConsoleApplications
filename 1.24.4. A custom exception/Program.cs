using System;

public class CustomException : ApplicationException
{
    public CustomException(string Message) : base(Message)
    {
        this.HelpLink = "See the Readme.txt file";
        this.Source = "My Program";
    }
}

class MainClass
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Throwing a new CustomException object");
            throw new CustomException("My CustomException message");
        }
        catch (CustomException e)
        {
            Console.WriteLine("HelpLink = " + e.HelpLink);
            Console.WriteLine("Message = " + e.Message);
            Console.WriteLine("Source = " + e.Source);
            Console.WriteLine("StackTrace = " + e.StackTrace);
            Console.WriteLine("TargetSite = " + e.TargetSite);
        }
    }
}
