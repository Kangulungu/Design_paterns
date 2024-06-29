using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique.Mutuelles
{
    public class Mutuelle1Factory : MutuelleFactoryAbstract
    {
        public override Mutuelle GetMutuelle()
        {
            return new Mutuelle1();
        }
    }
}
