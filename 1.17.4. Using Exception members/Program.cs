using System;

class MainClass
{
    public static void Main()
    {

        try
        {
            int[] nums = new int[4];

            Console.WriteLine("Before exception is generated.");

            // Generate an index out-of-bounds exception. 
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }
        }
        catch (IndexOutOfRangeException exc)
        {
            Console.WriteLine("Standard message is: ");
            Console.WriteLine(exc); // calls ToString() 
            Console.WriteLine("Stack trace: "            + exc.StackTrace);
            Console.WriteLine("Message: "                + exc.Message);
            Console.WriteLine("TargetSite: "             + exc.TargetSite);
            Console.WriteLine("Class defining member: {0}", exc.TargetSite.DeclaringType);
            Console.WriteLine("Member type: {0}"          , exc.TargetSite.MemberType);
            Console.WriteLine("Source: {0}"               , exc.Source);
            Console.WriteLine("Help Link: {0}"            , exc.HelpLink);

        }
        Console.WriteLine("After catch statement.");
    }
}