using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{   
    //Concrete Strategy A
    class Tank : Silah, IAskeriAraclar
    {

        public string Aciklama()
        {
            string aciklama = "Tank";
            return aciklama;
        }

        public void Ates()
        {

            Console.WriteLine("Tank Artık Ateşleyebilir.");
        }

        public double Maliyet()
        {
            double maliyet = 250.000;
            return maliyet;
        }

        //Factory Method absclasslardan türetildi.
        public override void Platform()
        {
            Console.WriteLine("Bu Silah Tankta kullanılabiir.");
        }
    }
}
