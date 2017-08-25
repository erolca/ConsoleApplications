using System;

class MainClass
{
    public static void Main()
    {
        string str = "while if for, public class do.";
        char[] seps = { ' ', '.', ',' };

        // Split the string into parts. 
        string[] parts = str.Split(seps);

        string whole = String.Join(" | ", parts);
        Console.WriteLine("Result of join: ");
        Console.WriteLine(whole);


    }
}

/*
 * Result of join:
while | if | for |  | public | class | do |

    */