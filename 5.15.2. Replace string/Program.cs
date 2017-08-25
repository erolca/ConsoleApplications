using System;

class MainClass
{
    public static void Main()
    {
        string str = "This test";

        Console.WriteLine("Original string: " + str);

        // Replace string 
        str = str.Replace("is", "was");
        Console.WriteLine(str);

    }
}

/*Original string: This test
Thwas test
*/