using System;
using System.Text;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string str = "abcdefghijklmnopqrstuvwxyz";

        str = ReverseString(str);
        Console.WriteLine(str);

        str = ReverseStringEnum(str);
        Console.WriteLine(str);
    }

    static string ReverseString(string strIn)
    {
        StringBuilder sb = new StringBuilder(strIn.Length);

        for (int i = 0; i < strIn.Length; ++i)
        {
            sb.Append(strIn[(strIn.Length - 1) - i]);
        }
        return sb.ToString();
    }

    static string ReverseStringEnum(string strIn)
    {
        StringBuilder sb = new StringBuilder(strIn.Length);
        foreach (char ch in strIn)
        {
            sb.Insert(0, ch);
        }

        return sb.ToString();
    }
}