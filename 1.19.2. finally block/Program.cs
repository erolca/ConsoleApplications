using System;
using System.IO;

class Processor
{
    public void ProcessFile()
    {
        FileStream f = new FileStream("wrongNameFile.txt", FileMode.Open);
        try
        {
            StreamReader t = new StreamReader(f);
            string line;
            while ((line = t.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        finally
        {
            f.Close();
        }
    }
}
class Test
{
    public static void Main()
    {
        Processor processor = new Processor();
        try
        {
            processor.ProcessFile();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: {0}", e);
        }
    }
}