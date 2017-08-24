using System;


//5.8.3.	Mix string and integer in string cancatenation
class MainClass
{
    public static void Main()
    {

        string result = String.Concat("hello ", 88, " ", 20.0, " ",
                               false, " ", 23.45M);
        Console.WriteLine("result: " + result);
    }
}