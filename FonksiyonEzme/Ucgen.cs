using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonksiyonEzme
{
    class Ucgen:Sekil   
    {

        public int yukseklik;
        public int taban;
        public Ucgen(int _yukseklik, int _taban)
        {

            yukseklik = _yukseklik;
            taban = _taban;

    }

        // override ezilme metot

        public override void Yazdir()
        {


            base.Yazdir();
            Console.WriteLine("-----------Ucgen.Yazdir()--------------------");
            Console.WriteLine(yukseklik);
            Console.WriteLine(taban);

        }




    }
}
