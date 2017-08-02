using System;

class MainClass
{
    public static void Main()
    {
        long inches;
        long miles;

        miles = 93000000; // 93,000,000 miles to the sun 

        // 5,280 feet in a mile, 12 inches in a foot 
        inches = miles * 5280 * 12;

        Console.WriteLine("Distance to the sun: " + inches + " inches.");

        /*2.13.2.	Calculate with ulong*/

        ulong loopCount = 0;
        ulong factorial = 1;
        loopCount = 23;
        for (ulong i = loopCount; i > 0; i--)
        {
            factorial *= i;
        }
        Console.WriteLine("{0}! = {1}", loopCount, factorial);

       /* 2.13.3.Overflowing the Bounds of a float*/
        System.Console.WriteLine(-1f / 0);
        System.Console.WriteLine(3.402823E+38f * 2f);

       /* 2.13.4.Dividing a Float by Zero, Displaying NaN*/
        float n = 0f;
        System.Console.WriteLine(n / 0);

    }
}
 