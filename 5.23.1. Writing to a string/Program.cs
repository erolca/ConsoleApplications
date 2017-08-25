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

        StringWriter writer = new StringWriter();
        writer.Write("Name: {0}, Age: {1}", "Henry", 32);
        Console.WriteLine(writer.ToString());
    }
}