using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class MainClass   
    {
    static double? GetNullableDouble()
    {
        double? result;
        string userInput = Console.ReadLine();
        try
        {
            result = double.Parse(userInput);
        }
        catch
        {
            result = null;
        }
        return result;
    }


    static void Main(string[] args)
        {
        }
    }

