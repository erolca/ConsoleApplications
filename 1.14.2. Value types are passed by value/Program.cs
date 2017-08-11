using System;

class Test
{
    /* This method causes no change to the arguments used in the call. */
    public void noChange(int i, int j)
    {
        i = i + j;
        j = -j;
    }
}

class MainClass
{
    public static void Main()
    {
        Test ob = new Test();

        int a = 15, b = 20;

        Console.WriteLine("a and b before call: " +
                           a + " " + b);

        ob.noChange(a, b);

        Console.WriteLine("a and b after call: " +
                           a + " " + b);
    }
}