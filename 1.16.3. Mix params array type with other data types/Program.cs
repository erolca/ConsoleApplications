using System;

class MainClass
{
    public static void ArrayOfInts(string msg, params int[] list)
    {
        Console.WriteLine(msg);

        for (int i = 0; i < list.Length; i++)
            Console.WriteLine(list[i]);
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] intArray = new int[3] { 10, 11, 12 };
        ArrayOfInts("Here is an array of ints", intArray);
        ArrayOfInts("Enjoy these 3 ints", 1, 2, 3);
        ArrayOfInts("Take some more!", 55, 4, 983, 10432, 98, 33);
    }
}