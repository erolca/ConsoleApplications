using System;

class MainClass
{
    static void Main()
    {
        int first = 5, second = 6, third = 7;

        ListInts(first, second, third);

        Console.WriteLine("{0}, {1}, {2}", first, second, third);
    }
    public static void ListInts(params int[] inVals)
    {
        for (int i = 0; i < inVals.Length; i++)
        {
            inVals[i] = inVals[i] * 10;
            Console.WriteLine("{0} ", inVals[i]);
        }
    }

}