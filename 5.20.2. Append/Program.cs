using System;
using System.Text;

public class MainClass
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("A ").Append("B ").Append("C... ");

        string built1 = sb.ToString();

        sb.Append("D");

        string built2 = sb.ToString();

        Console.WriteLine(built1);
        Console.WriteLine(built2);
    }
}