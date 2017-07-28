using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Override
{

    class insan
{

    private string adi;
    private string soyadi;

    public string  Soyadi
    {

        get { return soyadi; }
        set { soyadi = value; }

    }
    public string Adi
    {

        get { return adi; }
        set { adi = value; }

    }


    public virtual void bilgileriYazdir()
    {

        Console.WriteLine("Kişi Bilgileri " + this.adi +" "+this.soyadi);
    }
}


class ogrenci:insan
{

    private int ogrencino;
    
    public int ogrenciNo
    {

        get { return ogrencino; }
        set { ogrencino = value; }

    }

    public override void bilgileriYazdir()
    {

        Console.WriteLine("Öğrenci Bilgileri " + base.Adi + " " + base.Soyadi + " " + this.ogrencino);
    }
}






    class Program
    {
        static void Main(string[] args)
        {

            insan insan1 = new insan();
            insan1.Adi = "Burak";
            insan1.Soyadi = "Tungut";
            insan1.bilgileriYazdir();


            ogrenci ogrenci1 =new ogrenci();
            ogrenci1.Adi = "Anil";
            ogrenci1.Soyadi = "Yılmaz";
            ogrenci1.ogrenciNo = 1131;
            ogrenci1.bilgileriYazdir();


            

            ogrenci ogrenci2 = new ogrenci();
            insan insan2 = ogrenci2;
            insan2.Adi = "Ertan";
            insan2.Soyadi = "Kocaman";
            ogrenci2.ogrenciNo = 56598;
            ogrenci2.bilgileriYazdir();

            Console.ReadLine();
           

        }
    }
}
