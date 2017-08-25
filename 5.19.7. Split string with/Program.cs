using System;


//5.19.7.	Split string with \\
class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        char delim = '\\';
        string filePath = "C:\\Windows\\Temp";
        string[] directories = null;

        directories = filePath.Split(delim);

        foreach (string directory in directories)
        {
            Console.WriteLine("{0}", directory);
        }

    }
}