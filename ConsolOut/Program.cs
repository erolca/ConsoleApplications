using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsolOut
{
    class Program
    {
        private const int tabSize = 15;
        public static int Main(string[] args)
        {
            //StreamWriter writer = new StreamWriter("d:\\test.txt"/*args[0]*/);
            //Console.SetOut(writer);
            // DateTime localDate = DateTime.Now;
            // Console.WriteLine("The time for this array is: " + localDate);
            // // Console.SetIn(new StreamReader("d:\\test.txt"));
            // string line = "asdf";
            // Console.WriteLine(line);

            //writer.Close();
            // StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
            // standardOutput.AutoFlush = true;
            // Console.SetOut(standardOutput);
            // Console.WriteLine("");


            StreamWriter writer = null;
            string path = "d:\\text.txt";
            //writer = new StreamWriter(path);
           // Console.SetOut(writer);
            Console.SetIn(new StreamReader(path));
            string line;


            while ((line = Console.ReadLine()) != null)
            {
                string newLine = line.Replace(("").PadRight(tabSize, '.'), "\t");
                Console.WriteLine(newLine);

            }

            /*replace*/
            String s = "aaa";
            Console.WriteLine("The initial string: '{0}'", s);
            s = s.Replace("a", "b").Replace("b", "c").Replace("c", "d");
            Console.WriteLine("The final string: '{0}'", s);


            /*PadRight*/
            string str = "forty-two";
            char pad = '.';

            Console.WriteLine(str.PadRight(15, pad));    // Displays "forty-two......".
            Console.WriteLine(str.PadRight(2, pad));    // Displays "forty-two".

            return 0;

        }

/*
        static void Main(string[] args)
        {
            string fileName = "test.txt";
            string textToAdd = "Example text in file";


            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.Write(textToAdd);
            }
        }*/
        }
}
