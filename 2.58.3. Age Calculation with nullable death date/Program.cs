using System;
using System.ComponentModel;

class Person
{
    DateTime birth;
    DateTime? death;
    string name;

    public TimeSpan Age
    {
        get
        {
            if (death == null)
            {
                return DateTime.Now - birth;
            }
            else
            {
                return death.Value - birth;
            }
        }
    }

    public Person(string name, DateTime birth, DateTime? death)
    {
        this.birth = birth;
        this.death = death;
        this.name = name;
    }

    public static void Main()
    {
        Person turing = new Person("A", new DateTime(1913, 2, 23), new DateTime(1954, 6, 7));
        Person knuth = new Person("D", new DateTime(1978, 1, 10), null);
    }
}