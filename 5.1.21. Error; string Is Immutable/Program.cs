class Uppercase
{
    static void Main()
    {
        string text;

        System.Console.Write("Enter text: ");
        text = System.Console.ReadLine();
        text.ToUpper();
        System.Console.WriteLine(text);
    }
}