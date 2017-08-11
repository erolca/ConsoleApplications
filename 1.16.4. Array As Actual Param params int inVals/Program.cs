using System;

class MainClass
{
    public static void ListInts(params int[] inVals)
    {
        if (inVals != null)
            for (int i = 0; i < inVals.Length; i++)
                inVals[i] = inVals[i] * 10;
    }

    static void Main()
    {
        int[] MyArr = new int[] { 5, 6, 7 };

        ListInts(MyArr);

        foreach (int x in MyArr)
            Console.WriteLine("{0}", x);
    }
}