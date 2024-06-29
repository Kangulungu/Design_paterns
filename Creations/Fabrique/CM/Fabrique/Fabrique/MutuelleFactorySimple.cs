using Fabrique.Mutuelles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique
{
    public class MutuelleFactorySimple
    {
        public Mutuelle GetMutuelle( Patient p) {
            if (string.IsNullOrEmpty(p.NumeroMutuelle)) return new Mutuelle3();
            if (p.NumeroMutuelle.StartsWith("003")) return new Mutuelle2();
            
            return new Mutuelle1();
        }
    }
}
