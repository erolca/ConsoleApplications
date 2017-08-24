using System;

public class MyClass : IDisposable
{
    public MyClass()
    {
        Console.WriteLine("constructor");
    }

    ~MyClass()
    {
        Console.WriteLine("destructor");
    }

    public void Dispose()
    {
        Console.WriteLine("implementation of IDisposable.Dispose()");
    }
}

public class MainClass
{
    static void Main()
    {
        using (MyClass MyObject = new MyClass())
        {
        }
    }
}