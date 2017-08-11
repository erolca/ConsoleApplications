using System;

class Test
{
    public int a, b;

    public Test(int i, int j)
    {
        a = i;
        b = j;
    }

    /* Now, ob.a and ob.b in object 
       used in the call will be changed. */
    public void change(Test ob)
    {
        ob.a = ob.a + ob.b;
        ob.b = -ob.b;
    }
}

class MainClass
{
    public static void Main()
    {
        Test ob = new Test(15, 20);

        Console.WriteLine("ob.a and ob.b before call: " +
                           ob.a + " " + ob.b);

        ob.change(ob);

        Console.WriteLine("ob.a and ob.b after call: " +
                           ob.a + " " + ob.b);
    }
}