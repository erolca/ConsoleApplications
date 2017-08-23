using System;

public sealed class ComplexNumber
{
    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    private readonly double real;
    private readonly double imaginary;
}

public sealed class MainClass
{
    static void Main()
    {
        ComplexNumber num1 = new ComplexNumber(1.12345678, 2.12345678);

        string str = (string)Convert.ChangeType(num1, typeof(string));

       // Array obj = Enum.GetValues(typeof(EmployeeType));
    }
}