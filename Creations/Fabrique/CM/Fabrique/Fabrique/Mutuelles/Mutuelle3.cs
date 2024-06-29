using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique.Mutuelles
{
    public class Mutuelle3 : Mutuelle
    {
        public override decimal GetPourcentageRemboursementMedecinTraitant()
        {
            return 0m;
        }
    }
}
