using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    //Decorator
    abstract class OzellikDecorator : IAskeriAraclar
    {
        IAskeriAraclar _ozellik;
        public OzellikDecorator(IAskeriAraclar _ozellik)
        {
            this._ozellik = _ozellik;
        }

        public string Aciklama()
        {
            return _ozellik.Aciklama();
        }

        public void Ates()
        {
            _ozellik.Ates();
        }

        public double Maliyet()
        {
            return _ozellik.Maliyet();
        }
    }
}
