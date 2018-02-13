using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestation
{
    enum Taste
    {
        Vanilla,
        Almond,
        Limon
    }
    class Wafer :Sweet
    {
        Taste taste;
        bool glaze;

        public Wafer(string name, int weight, int caloties, double price, Taste taste, bool glaze) 
            : base(name, weight, caloties, price)
        {
            this.taste = taste;
            this.glaze = glaze;
        }

        public override string ToString()
        {
            String info = String.Format("WAFER\n" + base.ToString() + " taste - {0}\n flaze - {1}\n", taste, glaze);
            return info;
        }
    }
}
