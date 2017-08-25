using System;


/*5.14.3.	String format: {0,3:D}, {1,8:D}*/

class MainClass
{
    public static void Main()
    {
        int sum = 0, prod = 1;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            prod *= i;
            string str = String.Format("Sum:{0,3:D}  Product:{1,8:D}",
                                sum, prod);
            Console.WriteLine(str);
        }
    }
}
