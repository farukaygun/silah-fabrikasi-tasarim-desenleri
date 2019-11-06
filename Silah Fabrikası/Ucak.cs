using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    //Concrete Component
    class Ucak : Silah, IAskeriAraclar
    {
        public string Aciklama()
        {
            string aciklama = "Uçak";
            return aciklama;
        }

        public void Ates()
        {
            Console.WriteLine("Ateş Hazır");
        }

        public double Maliyet()
        {
            double maliyet = 500.000;
            return maliyet;
        }

        //Factory Method absclasslardan türetildi.
        public override void Platform()
        {
            Console.WriteLine("Bu silah uçaklarda kullanılabilir.");
        }
    }
}
