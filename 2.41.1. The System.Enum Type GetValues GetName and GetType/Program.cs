using System;

enum Color
{
    red,
    green,
    yellow
}

public class MainClass
{
    public static void Main()
    {
        Color c = Color.red;

        // enum values and names
        foreach (int i in Enum.GetValues(c.GetType()))
        {
            Console.WriteLine("Value: {0} ({1})", i, Enum.GetName(c.GetType(), i));
        }


       /*other way*/
        Array enumData = Enum.GetValues(c.GetType());

        int sc= (Enum.GetValues(c.GetType()).Length);

        Console.WriteLine("This enum has {0} members.", enumData.Length);
        for (int i = 0; i < enumData.Length; i++)
        {
            Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
        }

    }
}