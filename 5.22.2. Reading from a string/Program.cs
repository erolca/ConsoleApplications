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

        string contents = "Test content";
        using (StringReader reader = new StringReader(contents))
        {
            int c;
            while ((c = reader.Read()) != -1)
            {
                Console.Write("{0} ", c);
            }
        }
    }
}

//84 101 115 116 32 99 111 110 116 101 110 116