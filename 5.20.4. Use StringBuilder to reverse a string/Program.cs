using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        string str = "www.java2s.com";

        StringBuilder revStr = new StringBuilder();

        for (int count = str.Length - 1; count > -1; count--)
        {
            revStr.Append(str[count]);
        }

        Console.WriteLine(revStr.ToString());
    }
}

//moc.s2avaj.www