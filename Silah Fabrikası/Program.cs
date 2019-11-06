using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator Main
            //decorator uygulanacak component
            Ucak ucak = new Ucak();
            //componenti veriyoruz   deniz altına eğer olsaydı ucma metodu sayesinde Ucma özelliği eklenebilirdi.
            DenizAltı denizAltı = new DenizAltı(ucak);
            //decorator üzerinden component yeni metotlara sahip oluyor.

            denizAltı.Ates();
            denizAltı.MesajGonder("Maliyet");

            //Factory Method
            UretSilah uretSilah = new UretSilah();
            Silah tSilah = uretSilah.FactoryMethod(Araclar.Tank);
            Silah uSilah = uretSilah.FactoryMethod(Araclar.Ucak);

            tSilah.Platform();
            uSilah.Platform();


            //Observer Factory

            AskeriUs askeriUs = new AskeriUs { Bilgi = "İşlemciler Piyasada" };
            askeriUs.Bilgi = "İşlemciler Gelişiyor";

            askeriUs.AddOperator(new OrtakOperator { OperatorIsmi = "Faruk" });

            askeriUs.Bilgi = "Sarı Alarm !";
            Console.WriteLine(" ");
            askeriUs.Bilgi = "Emir İptal";

            askeriUs.AddOperator(new TankOperator { TankId = 102 });
            askeriUs.Bilgi = "Sınır İhlali";
        }
    }
}
