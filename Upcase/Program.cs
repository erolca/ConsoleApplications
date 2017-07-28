using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Upcase;



namespace Upcase
{

    


    class Program
    {

        static public Kare SolaKareYerlestir(Sekil s1)
        {
            Kare ret = new Kare();
            int x = s1.x - 20;
            int y = s1.y;
            ret.x = x;
            ret.y = y;

            return ret;

        }


        static void Main(string[] args)
        {

            /*Upcase */
            /*   Kare kare = new Kare();
               kare.x = 15;
               kare.y = 20;


            Sekil sekil1 = kare;
            sekil1.yazdir();

            sekil1.x = 45;
            sekil1.y = 50;
            sekil1.yazdir();*/


            int diziBoyutu = 10;

            Sekil[] sekiller = new Sekil[diziBoyutu];

            Ucgen uc1 = new Ucgen();

            sekiller[0] = new Ucgen();    //uc1; // new Ucgen();
            sekiller[0].x = 20;
            sekiller[0].y = 40;
            sekiller[0].yazdir();


            /*DownCase*/
            Ucgen uc2 = (Ucgen) sekiller[0]; /* uc2 ile uc1 aynı referansa sahiptir */
            uc2.taban = 15;
            uc2.yukseklik = 35;
            uc2.yazdir();

            sekiller[1] = SolaKareYerlestir(uc1 /*sekiller[0]*/);
            sekiller[1].yazdir();

            sekiller[2] = SolaKareYerlestir(sekiller[1]);/*fonksiyon geri donusu kare sınıfından */
            sekiller[2].yazdir();

            sekiller[3] = SolaKareYerlestir(sekiller[2]);/*fonksiyon geri donusu kare sınıfından */
            sekiller[3].yazdir();

            sekiller[3] = null;



            Console.WriteLine("****************************for****************************************");
            for (int i=0;i<diziBoyutu;i++)
            {
                if (sekiller[i] != null)
                {
                    if (sekiller[i] is Ucgen)
                    {
                        Console.Write(i + " .eleman bir ucgendir: ");
                    }
                    if (sekiller[i] is Kare)
                    {
                        Console.Write(i + " .eleman bir karedir: ");
                    }

                    sekiller[i].yazdir();

                }
                    


            }


        }
    }
}
