using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "one";
        string str2 = "one";

        if (String.Compare(str1, str2) == 0)
            Console.WriteLine(str1 + " and " + str2 +
                              " are equal.");
        else
            Console.WriteLine(str1 + " and " + str2 +
                              " are not equal.");

    }
}