using System;

class Person
{
    public string fullName;
    public int age;

    public Person(string n, int a)
    {
        fullName = n;
        age = a;
    }

    public void PrintInfo()
    {
        Console.WriteLine("{0} is {1} years old", fullName, age);
    }
}

class MainClass
{
    public static void SendAPersonByValue(Person p)
    {
        p.age = 99;

        p = new Person("TOM", 999);
    }

    public static void Main()
    {
        Person fred = new Person("Fred", 12);
        fred.PrintInfo();
        SendAPersonByValue(fred);
        fred.PrintInfo();
    }
}