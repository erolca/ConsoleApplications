using System;

class MyClass
{
    int a, b;

    public MyClass(int i, int j)
    {
        a = i;
        b = j;
    }

    /* Return true if ob contains the same values as the invoking object. */
    public bool sameAs(MyClass ob)
    {
        if ((ob.a == a) & (ob.b == b))
            return true;
        else return false;
    }

    public void copy(MyClass ob)
    {
        a = ob.a;
        b = ob.b;
    }

    public void show()
    {
        Console.WriteLine("a: {0}, b: {1}",
                          a, b);
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass ob1 = new MyClass(4, 5);
        MyClass ob2 = new MyClass(6, 7);

        Console.Write("ob1: ");
        ob1.show();

        Console.Write("ob2: ");
        ob2.show();

        if (ob1.sameAs(ob2))
            Console.WriteLine("ob1 and ob2 have the same values.");
        else
            Console.WriteLine("ob1 and ob2 have different values.");

        Console.WriteLine();

        // now, make ob1 a copy of ob2 
        ob1.copy(ob2);

        Console.Write("ob1 after copy: ");
        ob1.show();

        if (ob1.sameAs(ob2))
            Console.WriteLine("ob1 and ob2 have the same values.");
        else
            Console.WriteLine("ob1 and ob2 have different values.");

    }
}