using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "one";
        string str2 = "two";

        int result = String.Compare(str1, str2);
        if (result < 0)
            Console.WriteLine(str1 + " is less than " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " is greater than " + str2);
        else
            Console.WriteLine(str1 + " equals " + str2);
    }
}