using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int number = 1;

        sb.AppendFormat("{0}: {1} ", number++, "another string");

        Console.WriteLine("{0}", sb);
    }
}