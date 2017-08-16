using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Nesne tabanlı programlamada sınıf hiyerarşisi oluşturulurken, bazen en tepede bulunan sınıf türünden nesneler programcılar için anlamlı olmayabilir.
 Hiyerarşinin en tepesinde bulunan sınıfın kendisinden türetilecek olan alt sınıflar için ortak bir arayüz (interface) görevi yapması istenebilir. 
 Bunun için çözüm olarak oluşturulan metotlara ve sınıflara soyut metot (abstract method) ya da soyut sınıf (abstract class) denir. 
 Soyut sınıflar büyük projelerde kullanılırlar ve kalıtım özelliğini kullanarak kod tekrarını azaltırlar. 
 Soyut sınıflar diğer sınıflara taban olmak için kullanılırlar. Nesne türetemezler. Önlerine “abstract” sözcüğü yazılarak soyutlaştırılırlar. 
 Önlerine "virtual" yazılmaz çünkü “abstract” sözcüğü uygulanan tüm sınıf ve metotlar zaten sanaldır.
 Abstract Class: abstract olarak tanımlanan bir sınıf temel sınıftır.
 Bu sınıftan new anahtar kelimesi kullanılarak bir nesne oluşturulamaz.

Kullanırken dikkat edilmesi gerekenler:

•    Soyut sınıflar “abstract” türünden nesneler tanımlamazlar.
•    Soyut sınıflar içerilerinde soyut olmayan metotlar da barındırabilir ancak soyut metotlar sadece soyut sınıflar içerisinde bildirilebilir.
•    Soyut metotlar türeyen sınıfta mutlaka bildirilmelidir.
•    Soyut metotlar override edilmek zorundadırlar, aksi takdirde derleyici hatası alınır.
•    “Static” metotlar soyut olarak tanımlanamazlar. 
•    Soyut sınıflar “private” olarak tanımlanamazlar ama “public” ve “protected” olarak tanımlanabilirler.
•    Soyut sınıflar “sealed” anahtar sözcüğü ile ifade edilemezler.  
 * 
 */


 public  abstract class Kisi
    {

        public string AdSoyad;

        public  abstract string  Meslek
        {

            get;
        }

        public  virtual void Yaz()
        {
            Console.WriteLine("Adı Soyadı :" + AdSoyad);
            Console.WriteLine("Mesleği :" + Meslek);

        }
    }

    public class Ogrenci : Kisi
    {
        public int Sinif;
        public  override string Meslek
        {
            get
            {
                return "Ogrenci";


            }

        }
        //virtual methodun  override edilmesi
        public override void Yaz()
        {
            Console.WriteLine("Adı Soyadı :" + AdSoyad);
            Console.WriteLine("Mesleği :" + Meslek);
            Console.WriteLine("Sınıfı :" + Sinif);

        }
    }


    public class Ogretmen : Kisi
    {

        public string Brans ;
        public override string Meslek
        {
            get
            {
                return "Öğretmen";


            }

        }

        //virtual methodun  override edilmesi
        public override void Yaz()
        {
            Console.WriteLine("Adı Soyadı :" + AdSoyad);
            Console.WriteLine("Mesleği :" + Meslek);
            Console.WriteLine("Branşı :" + Brans);
        }
    }


    /*msdn*/
    abstract class ShapesClass
    {
        abstract public int Area();
    }
class Square : ShapesClass
{
    int side = 0;

    public Square(int n)
    {
        side = n;
    }
    // Area method is required to avoid
    // a compile-time error.
    public override int Area()
    {
        return side * side;
    }
}


        interface I
        {
            void M();
        }
        abstract class C : I
        {
            public abstract void M();
        }


        class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0}", sq.Area());

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.AdSoyad = "Barack Obama";
            ogrenci1.Sinif = 12;
            ogrenci1.Yaz();


            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.AdSoyad = "Junior Bush";
            ogretmen1.Brans = "Devlet Yonetimi";
            ogretmen1.Yaz();

            Console.ReadLine();


        }
    }

