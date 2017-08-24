using System;

interface Printable
{
    void print(string name);
}
class Paper : Printable
{
    public void print(string name)
    {
        Console.WriteLine("Poking {0}", name);
    }
}
class NonPrintablePaper
{
}
class MainClass
{
    public static void Test(string sister, params object[] papers)
    {
        foreach (object o in papers)
        {
            if (o is Printable)
            {
                Printable p = (Printable)o;
                p.print(sister);
            }
        }
    }
    public static void Main()
    {
        Test("Test", new Paper(), new NonPrintablePaper());
    }
}