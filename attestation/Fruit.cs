using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestation
{
    class Fruit : Sweet
    {
        int vitaminC;
        int vitaminA;

        public Fruit(string name, int weight, int caloties, double price, int vitaminC, int vitaminA) 
            : base(name, weight, caloties, price)
        {
            this.vitaminC = vitaminC;
            this.vitaminA = vitaminA;
        }

        public override string ToString()
        {
            String info = String.Format("FRUIT\n" + base.ToString() + " vitaminC - {0}\n vitaminA - {1}\n", vitaminC, vitaminA);
            return info;
        }
        
    }
}
