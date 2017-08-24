using System;
using System.Text;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string sLiteral = "Automatically Interned";
        string sNotInterned = "Not " + sLiteral;

        TestInterned(sLiteral);
        TestInterned(sNotInterned);

        String.Intern(sNotInterned);
        TestInterned(sNotInterned);

        string string1 = "";
        String string2 = "";

        string1 = "asdf";
        string2 = "asdf1";

    }

    static void TestInterned(string str)
    {
        if (String.IsInterned(str) != null)
        {
            Console.WriteLine("The string \"{0}\" is interned.", str);
        }
        else
        {
            Console.WriteLine("The string \"{0}\" is not interned.", str);
        }
    }
}