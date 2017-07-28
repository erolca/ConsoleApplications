using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonksiyonEzme
{
    class Kare:Sekil
    {

        public int boyut;
        public Kare(int _boyut)
        {

            boyut = _boyut;

        }

        // new ile tanımlanmış fonksiyonda, sekil içindeki Yazdir fonksiyonu işletilmekte
        // Overrride ila tanımlanmış fonk. Kare içindeki Yazdir işletilmekte
        public override void Yazdir()
        {

            base.Yazdir();
            Console.WriteLine("-----------Kare.Yazdir()----------------");
            Console.WriteLine(boyut);

        }

    }
}
