using System;

public class Employee
{
    public Employee(string Name)
    {
        this.firstName = firstName;
        this.terminationDate = null;
        this.ssn = default(Nullable<long>);
    }

    public string firstName;
    public Nullable<DateTime> terminationDate;
    public long? ssn;
}

public class MainClass
{
    static void Main()
    {
        Employee emp = new Employee("A");
        emp.ssn = 1234567890;

        Console.WriteLine("{0} {1}", emp.firstName);
        if (emp.terminationDate.HasValue)
        {
            Console.WriteLine("Start Date: {0}", emp.terminationDate);
        }

        long tempSSN = emp.ssn ?? -1;
        Console.WriteLine("SSN: {0}", tempSSN);
    }
}