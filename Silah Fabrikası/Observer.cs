using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silah_Fabrikası
{
    //SUBJECT CLASS
    internal abstract class Merkez
    {
        private string _bilgi;
        private List<IOperator> _operators = null;

        protected Merkez(string bilgi)
        {
            _operators = new List<IOperator>();
            Bilgi = bilgi;
        }

        public string Bilgi
        {
            get { return _bilgi; }
            set
            {
                _bilgi = value;
                NotifyOperators();
            }
        }

        public void AddOperator(IOperator opt)
        {
            _operators.Add(opt);
        }
        public void RemoveOperator(IOperator opt)
        {
            _operators.Remove(opt);
        }
        public void NotifyOperators()
        {
            foreach (IOperator opt in _operators)
            {
                opt.Update(this);
            }
        }
        //internal class AskeriUs
        //: Merkez
        // {
        //     public AskeriUs(string bilgi)
        //        : base(bilgi)
        //     {

        //     }

        //     public AskeriUs()
        //         : base("...")
        //     {

        //     }

        // }
    }
}

