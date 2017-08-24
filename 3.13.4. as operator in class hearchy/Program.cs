using System;

class A { }
class B : A { }

class MainClass
{
    public static void Main()
    {
        A a = new A();
        B b = new B();

        b = a as B; // cast, if possible 

        if (b == null)
            Console.WriteLine("Cast b = (B) a is NOT allowed.");
        else
            Console.WriteLine("Cast b = (B) a is allowed");
    }
}