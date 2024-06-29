using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrique_Abstraite.ConcreteProducts;
using Fabrique_Abstraite.IAbstractProducts;

namespace Fabrique_Abstraite.ConcreteFactorys
{
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
