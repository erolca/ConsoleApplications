class Uppercase
{
    static void Main()
    {
        System.Console.Write("Enter text: ");
        var text = System.Console.ReadLine();
        var uppercase = text.ToUpper();
        System.Console.WriteLine(uppercase);
    }
}