using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{ //Observer class
    internal interface IOperator
    {
        void Update(Merkez merkez);
    }

    internal class OrtakOperator : IOperator
    {
        public string OperatorIsmi { get; set; }
        public void Update(Merkez merkez)
        {
            Console.WriteLine("[{0}] : {1}", OperatorIsmi, merkez.Bilgi);
        }
    }
}
