using System;

class Min
{
    public int minVal(params int[] nums)
    {
        int m;

        if (nums.Length == 0)
        {
            Console.WriteLine("Error: no arguments.");
            return 0;
        }

        m = nums[0];
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] < m) m = nums[i];

        return m;
    }
}

class MainClass
{
    public static void Main()
    {
        Min ob = new Min();
        int min;
        int a = 10, b = 20;

        // call with two values 
        min = ob.minVal(a, b);
        Console.WriteLine("Minimum is " + min);

        // call with 3 values 
        min = ob.minVal(a, b, -1);
        Console.WriteLine("Minimum is " + min);

        // call with 5 values 
        min = ob.minVal(18, 23, 3, 14, 25);
        Console.WriteLine("Minimum is " + min);

        // can call with an int array, too 
        int[] args = { 45, 67, 34, 9, 112, 8 };
        min = ob.minVal(args);
        Console.WriteLine("Minimum is " + min);
    }
}