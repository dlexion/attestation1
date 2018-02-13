using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestation
{
    enum Stuffing
    {
        Nut,
        Marmalade,
        Fudge,
        NoStuffing
    }

    class Candy : Sweet
    {
        int cacaoContent;
        Stuffing stuffing;

        public Candy(string name, int weight, int caloties, double price, int cacaoContent, Stuffing stuffing) 
            : base(name, weight, caloties, price)
        {
            this.cacaoContent = cacaoContent;
            this.stuffing = stuffing;
        }

        public override string ToString()
        {
            String info = String.Format("Candy\n" + base.ToString() + " cacao content - {0}\n stuffing - {1}\n", cacaoContent, stuffing);
            return info;
        }
    }
}
