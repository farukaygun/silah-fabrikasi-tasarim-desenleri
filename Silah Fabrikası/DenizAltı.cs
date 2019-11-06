using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    //Concrte Decoacrtor
    class DenizAltı : OzellikDecorator
    {
        string Maliyet = "150.000";
        public DenizAltı(IAskeriAraclar _ozellik) : base(_ozellik)
        {
        }

        public void MesajGonder(string mesaj)
        {
            Console.WriteLine("{0} mesajı gönderildi.", mesaj);

            if (mesaj == "Maliyet")
            {
                //
            }
        }
    }
}
