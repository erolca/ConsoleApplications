using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CokBicimlilik_MetotEzme
{
    class Kare:Sekil
    {

        public int boyut;
        public Kare(int _boyut)
        {

            boyut = _boyut;

        }


        public new void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("-----------Kare.Yazdir()----------------");
            Console.WriteLine(boyut);

        }

    }
}
