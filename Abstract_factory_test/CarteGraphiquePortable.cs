using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory_test
{
    class CarteGraphiquePortable : CarteGraphique
    {
        public CarteGraphiquePortable(string modele, string chipset, string memoire) : base(modele, chipset, memoire)
        {
        }
        public override void afficherDetail()
        {
            Console.WriteLine("carte mere pour pc fixe cree :" + modele + "chipset integre :" + chipset + memoire + "mo de ram");
        }
    }
}
