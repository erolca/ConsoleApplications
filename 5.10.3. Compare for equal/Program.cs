using System;

class MainClass
{
    public static void Main()
    {
        string str1 = "ABCDEabcde1234567890";
        string str2 = string.Copy(str1);
        string str3 = "asdf";


        // compare strings 
        if (str1 == str2)
            Console.WriteLine("str1 == str2");
        else
            Console.WriteLine("str1 != str2");

        if (str1 == str3)
            Console.WriteLine("str1 == str3");
        else
            Console.WriteLine("str1 != str3");

    }

}