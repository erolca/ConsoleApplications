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
    public static void ArrayOfObjects(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] is Person)
            {
                ((Person)list[i]).PrintInfo();
            }
            else
                Console.WriteLine(list[i]);
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        Person p = new Person("Fred", 93);
        ArrayOfObjects(7, p, "System.String");
    }
}