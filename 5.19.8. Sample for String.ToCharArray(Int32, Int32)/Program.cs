using System;

class Sample
{
    public static void Main()
    {
        string str = "012wxyz789";
        char[] arr;

        arr = str.ToCharArray(3, 4);
        Console.Write("The letters in '{0}' are: '", str);
        Console.Write(arr);
        Console.WriteLine("'");
        Console.WriteLine("Each letter in '{0}' is:", str);
        foreach (char c in arr)
            Console.WriteLine(c);
    }
}