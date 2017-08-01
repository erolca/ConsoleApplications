using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Security.Cryptography;
/* 2.4.2.	Integer Types
*  Type          Size           Range (Inclusive)                                           BCL Name                 Signed
*   sbyte         8 bits         -128 to 127                                                 System.SByte             Yes
*   byte          8 bits         0 to 255                                                    System.Byte              No
*   short         16 bits        -32,768 to 32,767                                           System.Int16             Yes
*   ushort        16 bits        0 to 65,535                                                 System.UInt16            No
*   int           32 bits        -2,147,483,648 to 2,147,483,647                             System.Int32             Yes
*   uint          32 bits        0 to 4,294,967,295                                          System.UInt32            No
*   long          64 bits        -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807     System.Int64             Yes
*   ulong         64 bits        0 to 18,446,744,073,709,551,615                             System.UInt64            No
 */
public class MainClass
{
    
    public static void Main()
    {
        
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(byte).ToString(), sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(char).ToString(), sizeof(char), (int)char.MinValue, (int)char.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(short).ToString(), sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(int).ToString(), sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(long).ToString(), sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(sbyte).ToString(), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(ushort).ToString(), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(uint).ToString(), sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0}: bytes: {1}, range: [{2},{3}]",
            typeof(ulong).ToString(), sizeof(ulong), ulong.MinValue, ulong.MaxValue);
    }

}