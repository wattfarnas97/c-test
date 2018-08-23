using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory_test
{
    public abstract class CarteMere
    {
        protected string modele;
        protected string chipset;

        public CarteMere(string modele,string chipset)
        {
            this.chipset = chipset;
            this.modele = modele;
        }
        public abstract void afficherDetail();
    }
}
