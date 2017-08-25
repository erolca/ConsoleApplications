using System;

class MainClass
{
    public static void Main()
    {
        string pswd = "asdf";

        string str = "fda";

        // Compare using invariant culture. 
        if (String.Compare(pswd, str,
                          StringComparison.InvariantCulture) == 0)
            Console.WriteLine("Password accepted.");
        else
            Console.WriteLine("Password invalid.");
    }
}