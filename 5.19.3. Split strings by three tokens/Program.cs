using System;

class MainClass
{
    public static void Main()
    {
        string str = "while if for, public class do.";
        char[] seps = { ' ', '.', ',' };

        // Split the string into parts. 
        string[] parts = str.Split(seps);
        Console.WriteLine("Pieces from split: ");
        for (int i = 0; i < parts.Length; i++)
            Console.WriteLine(parts[i]);

    }
}

/*
Pieces from split:
while
if
for

public
class
do
*/