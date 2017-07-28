using System;

class RefSwap
{
    int a, b;

    public RefSwap(int i, int j)
    {
        a = i;
        b = j;
    }

    public void show()
    {
        Console.WriteLine("a: {0}, b: {1}", a, b);
    }

    // This method changes its arguments. 
    public void swap(ref RefSwap ob1, ref RefSwap ob2)
    {
        RefSwap t;

        t = ob1;
        ob1 = ob2;
        ob2 = t;
    }
}

class MyClass
{
    public int Val = 20;
}

class MainClass
{


    static void MyMethod(out MyClass f3, out int f2)
    {
        f3 = new MyClass();
        f3.Val = 25;
        f2 = 15;
    }

    static void MyMethod_II (ref MyClass myObject, ref int intValue)
    {
        myObject.Val = myObject.Val + 5;
        intValue = intValue + 5;
    }


    public static void Main()
    {
        RefSwap x = new RefSwap(1, 2);
        RefSwap y = new RefSwap(3, 4);

        Console.Write("x before call: ");
        x.show();

        Console.Write("y before call: ");
        y.show();

        Console.WriteLine();

        // exchange the objects to which x and y refer 
        x.swap(ref x, ref y);

        Console.Write("x after call: ");
        x.show();

        Console.Write("y after call: ");
        y.show();





        // new exam
        //Use out for reference type

        MyClass myObject = null;
        int intValue=10;

        MyMethod(out myObject, out intValue);

        //out
        Console.WriteLine("After Use out for reference type -- myObject.Val: {0}, intValue: {1}", myObject.Val, intValue);

        //ref
        Console.WriteLine("Before -- myObject.Val: {0}, intValue: {1}", myObject.Val, intValue);

        MyMethod_II(ref myObject, ref intValue);

        Console.WriteLine("After  -- myObject.Val: {0}, intValue: {1}", myObject.Val, intValue);


    }
}