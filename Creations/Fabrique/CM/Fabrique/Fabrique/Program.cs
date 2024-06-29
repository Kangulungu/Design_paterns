// See https://aka.ms/new-console-template for more information
using Fabrique;
using Fabrique.Mutuelles;

Patient a = new Patient();
Patient b = new Patient();
b.NumeroMutuelle = "0034545789";
Patient c = new Patient();
c.NumeroMutuelle = "0057845666";


///Simple
Console.WriteLine("Mutuelle Simple");
var factoryS = new MutuelleFactorySimple();

Console.WriteLine("Patient a = " + factoryS.GetMutuelle(a).GetPourcentageRemboursementMedecinTraitant());
Console.WriteLine("Patient b = " + factoryS.GetMutuelle(b).GetPourcentageRemboursementMedecinTraitant());
Console.WriteLine("Patient c = " + factoryS.GetMutuelle(c).GetPourcentageRemboursementMedecinTraitant());

///Abstract
Console.WriteLine("Mutuelle Abstract");
MutuelleFactoryAbstract factoryA = new Mutuelle1Factory();
Console.WriteLine("Patient a = " + factoryA.GetMutuelle().GetPourcentageRemboursementMedecinTraitant());
factoryA = new Mutuelle2Factory();
Console.WriteLine("Patient b = " + factoryA.GetMutuelle().GetPourcentageRemboursementMedecinTraitant());
factoryA = new Mutuelle3Factory();
Console.WriteLine("Patient c = " + factoryA.GetMutuelle().GetPourcentageRemboursementMedecinTraitant());

