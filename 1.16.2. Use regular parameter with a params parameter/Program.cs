using System;

class MyClass
{
    public void showArgs(string msg, params int[] nums)
    {
        Console.Write(msg + ": ");

        foreach (int i in nums)
            Console.Write(i + " ");

        Console.WriteLine();
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass ob = new MyClass();

        ob.showArgs("Here are some integers",
                    1, 2, 3, 4, 5);

        ob.showArgs("Here are two more",
                    17, 20);

    }
}