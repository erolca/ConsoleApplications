using System;
using System.IO;


//5.18.8.	Use LastIndexOf(Char) to find the last directory separator character in a string and to extract the file name

public class MainClass
{
    public static void Main()
    {
        string filename;

        filename = ExtractFilename(@"C:\temp\notafile.txt");
        Console.WriteLine("{0}", String.IsNullOrEmpty(filename) ? "<none>" : filename);
    }

    public static string ExtractFilename(string filepath)
    {
        if (filepath.Trim().EndsWith(@"\"))
            return String.Empty;

        int position = filepath.LastIndexOf('\\');
        if (position == -1)
        {
            if (File.Exists(Environment.CurrentDirectory + Path.DirectorySeparatorChar + filepath))
                return filepath;
            else
                return String.Empty;
        }
        else
        {
            if (File.Exists(filepath))
                return filepath.Substring(position + 1);
            else
                return String.Empty;
        }
    }
}