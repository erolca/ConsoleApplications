using System;

class MainClass
{
    public static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];

        for (int i = 0; i < 10; i++)
            nums[i] = i;

        foreach (int x in nums)
        {
            Console.WriteLine("Value is: " + x);
            sum += x;
            if (x == 4)
                break; // stop the loop when 4 is obtained 
        }
        Console.WriteLine("Summation of first 5 elements: " + sum);
    }
}