using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CokBicimlilik_MetotEzme
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



        public new void Yazdir()
        {


            base.Yazdir();
            Console.WriteLine("-----------Ucgen.Yazdir()--------------------");
            Console.WriteLine(yukseklik);
            Console.WriteLine(taban);

        }




    }
}
