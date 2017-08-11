using System;

class MainClass
{
    public static void Main()
    {
        unchecked
        {
            byte a = 55;
            byte b = 210;
            byte c = (byte)(a + b);


            /*2.49.2.	An Unchecked Block Example*/

            // int.MaxValue equals 2147483647
            int n = int.MaxValue;
            n = n + 1;
            System.Console.WriteLine(n);

        }
    }
}
 