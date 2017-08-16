using System;
/*
 c# ın 2.0 surumundan itibaren int, byte ve long gibi value  tipleri null bilgisinin aktarılmasını desteklemektedir. 
Söz konusu Value tipe null aktarılmasına null izin verilsin istiyorsanız degişken tanımlarken tip adına(?) işaretine eklemelisiniz.

int? yil;
yil?=null;

sınıftan yararlanabilmek için;
System.Nullable<byte> Sayi1;
System.Nullable<int> Sayi2;
Sayi1=null;
Sayi2=null;
     
   */

class NullableExample
{
    static void Main()
    {
        int? num = null;

        // Is the HasValue property true?
        if (num.HasValue)
        {
            Console.WriteLine("num = " + num.Value);
        }
        else
        {
            Console.WriteLine("num = Null");
        }

        // y is set to zero
        int y = num.GetValueOrDefault();

        // num.Value throws an InvalidOperationException if num.HasValue is false
        try
        {
            y = num.Value;
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
// The example displays the following output:
//       num = Null
//       Nullable object must have a value.