using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory_test
{
    public abstract class CarteGraphique
    {
        protected string modele;
        protected string memoire;
        protected string chipset;

        public CarteGraphique(string modele, string chipset,string memoire)
        {
            this.chipset = chipset;
            this.modele = modele;
            this.memoire = memoire;
        }
        public abstract void afficherDetail();
    }
}
