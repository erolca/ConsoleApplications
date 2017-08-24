using System;

class MainClass
{
    public static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];

        for (int i = 0; i < 10; i++)
            nums[i] = i;

        Console.WriteLine("use foreach to display and sum the values");
        foreach (int x in nums)
        {
            Console.WriteLine("Value is: " + x);
            sum += x;
        }
        Console.WriteLine("Summation: " + sum);
    }
}