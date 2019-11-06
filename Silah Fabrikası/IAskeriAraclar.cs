using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    //Strateji Deseni, interface oluşturularak ortak özellikler buraya eklendi.

    //Dekoratör içinde IAskeriAracları kullandım. 
    interface IAskeriAraclar
    {
        void Ates();
        string Aciklama();
        double Maliyet();
    }
}
