using System;


class MainClass
{
    public static void Main(string[] args)
    {
        string formStr = null;
        formStr = string.Format("you had {0:C} in your account?", 99989.987);
        Console.WriteLine(formStr);
    }
}