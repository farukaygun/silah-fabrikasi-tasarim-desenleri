using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    //Concrete obs.
    internal class TankOperator : IOperator
    {
        public int TankId { get; set; }
        public void Update(Merkez merkez)
        {
            Console.WriteLine("[{0}] : {1}", TankId, merkez.Bilgi);
        }
    }
}
