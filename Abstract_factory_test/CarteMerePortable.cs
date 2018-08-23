using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory_test
{
     public class CarteMerePortable:CarteMere
    {
        public CarteMerePortable(string modele, string chipset):base(modele,chipset)
        {
        }
        public override void afficherDetail()
        {
            Console.WriteLine("carte mere pour pc fixe cree :" + modele + "chipset integre :" + chipset);
        }
    }
}
