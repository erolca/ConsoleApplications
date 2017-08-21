using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Method
{
    abstract class Ucak
    {
        public int YolcuKapasitesi { get; set; }
        public string UcakSirketi { get; set; }
        //Ucak’ların ortak Özellikleri’leri
        public abstract void UcakFiyati();
        //override edilecek abstract methodumuz
    }
    //Büyük Uçak Sınıfı
    class BuyukUcak : Ucak //Ucak Abstract Class’ından kalıtılan Class
    {
        public override void UcakFiyati() //Ucak Abstract Class’ından, Class kalıtırken override ettiğimiz, gövdesini doldurduğumuz method.
        {
            Console.WriteLine("Büyük Uçağın Fiyatı 5m");
            Console.ReadLine();
        }
    }
    //Küçük Uçak Sınıfı
    class KucukUcak : Ucak
    {
        public override void UcakFiyati()
        {
            Console.WriteLine("Küçük Uçağın Fiyatı 3m");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KucukUcak k = new KucukUcak();
            k.UcakFiyati();

        }
    }
}
