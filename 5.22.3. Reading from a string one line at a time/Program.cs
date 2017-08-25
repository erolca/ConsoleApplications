using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

public class MainClass
{
    public static void Main()
    {


        string contents = "Test content\r\nHello there";
        using (StringReader reader = new StringReader(contents))
        {
            int lineNo = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Line#{0}: {1}", ++lineNo, line);
            }
        }
    }
}

/*
Line#1: Test content
Line#2: Hello there
*/