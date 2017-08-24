using System;

class MainClass
{

    public static void Main()
    {
        bool boolResult;
        string myString = "str";
        string myString2 = "str2";

        boolResult = String.Equals("bbc", "bbc");
        Console.WriteLine("String.Equals(\"bbc\", \"bbc\") is " + boolResult);

        boolResult = myString.Equals(myString2);
        Console.WriteLine("myString.Equals(myString2) is " + boolResult);

        boolResult = myString == myString2;
        Console.WriteLine("myString == myString2 is " + boolResult);
    }

}