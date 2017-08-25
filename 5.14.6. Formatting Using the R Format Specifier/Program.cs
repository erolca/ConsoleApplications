class MainClass
{
    static void Main()
    {
        const double number = 1.612;
        double result;
        string text;

        text = string.Format("{0}", number);
        result = double.Parse(text);
        System.Console.WriteLine("{0}: result != number", result != number);

        text = string.Format("{0:R}", number);
        result = double.Parse(text);
        System.Console.WriteLine("{0}: result == number", result == number);

    }
}