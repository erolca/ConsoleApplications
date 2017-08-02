using System;

class RightAssocApp
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = 3;

        Console.WriteLine("a={0} b={1} c={2}", a, b, c);
        a = b = c;
        Console.WriteLine("After 'a=b=c': a={0} b={1} c={2}", a, b, c);

        /*2.7.3.	Overflowing an Integer Value*/
        // int.MaxValue equals 2147483647
        int n = int.MaxValue;
        n = n + 1;
        System.Console.WriteLine(n);

        /*2.7.4.	Bitwise AND of Integer*/

        Console.WriteLine("Enter an integer:");
        int myInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bitwise AND of Integer and 10 = {0}", myInt & 10);
        /*	2.7.5.	Comparing integers*/

        Console.WriteLine("Enter an integer:");
         myInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Integer less than 10? {0}", myInt < 10);
        Console.WriteLine("Integer between 0 and 5? {0}", (0 <= myInt) && (myInt <= 5));

    }
}
 
 