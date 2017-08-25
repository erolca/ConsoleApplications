using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "one";
        string str2 = "one, too";


        if (String.Compare(str1, 0, str2, 0, 3) == 0)
            Console.WriteLine("First part of " + str1 + " and " +
                              str2 + " are equal.");
        else
            Console.WriteLine("First part of " + str2 + " and " +
                              str2 + " are not equal.");

    }
}