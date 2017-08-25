using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "one";
        string str2 = "ONE";

        if (String.Compare(str1, str2, true) == 0)
            Console.WriteLine(str1 + " and " + str2 +
                              " are equal ignoring case.");
        else
            Console.WriteLine(str1 + " and " + str2 +
                              " are not equal ignoring case.");

    }
}