using Fabrique_Abstraite.ConcreteFactorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique_Abstraite
{
    class Client
    {
        public void Main() {
            Console.WriteLine("Test de client avec la 1ère factory type");
            // Le client doit connaître les fabriques
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Test de client avec la 2ième factory type");
            // Le client doit connaître les fabriques
            ClientMethod(new ConcreteFactory2());
            Console.WriteLine();

        }
        // Les fabriques concrètes sont du type de l'interface
        public void ClientMethod(IAbstractFactory factory) {
            // Via les fabriques concrètes  le client peut créer des Produits concrèts

            //Les produits concrets sont du type de l'interface a,b,c....
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            //Une fois le produit concrèt à disposition le client à accès au méthodes spécialisées
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
