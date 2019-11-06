using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    enum Araclar
    {
        Tank,
        Ucak
    }
    class UretSilah
    {
        public Silah FactoryMethod(Araclar aracturu)
        {
            Silah silah = null;
            switch (aracturu)
            {
                case Araclar.Tank:
                    silah = new Tank();
                    break;
                case Araclar.Ucak:
                    silah = new Ucak();
                    break;

            }
            return silah;
        }

    }
}
