using System;

class MainClass
{
    public static void Main()
    {
        Write("A", "B");
        Write("A", "B", "C", 12, 14.2);
        object[] arr = new object[4];
        arr[0] = "A";
        arr[1] = "B";
        arr[2] = "C";
        arr[3] = 42;
        Write("AAA", arr);
    }
    public static void Write(string label, object arg)
    {
        WriteString(label);
        WriteString(arg.ToString());
    }
    // version with an array of object parameters
    public static void Write(string label, params object[] args)
    {
        WriteString(label);
        foreach (object o in args)
        {
            WriteString(o.ToString());
        }
    }
    public static void WriteString(string str)
    {
        // writes string to the port here
        Console.WriteLine("Port debug: {0}", str);
    }

}