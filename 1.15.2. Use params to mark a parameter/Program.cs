using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static int SumVals(params int[] vals)
    {
        int sum = 0;
        foreach (int val in vals)
        {
            sum += val;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int sum = SumVals(1, 5, 2, 9, 8);
        Console.WriteLine("Summed Values = {0}", sum);

    }
}