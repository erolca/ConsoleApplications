using System;

class A { }
class B : A { }

class CheckCast
{
    public static void Main()
    {
        A a = new A();
        B b = new B();

        if (a is B)
            b = (B)a;
    }
}