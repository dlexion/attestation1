using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestation
{
    abstract class Sweet : IComparable<Sweet>
    {
        String name;
        int weight;//граммы
        int caloricity;
        double price;

        public Sweet()
        {
        }

        public Sweet(string name, int weight, int caloties, double price)
        {
            this.name = name;
            this.weight = weight;
            this.caloricity = caloties;
            this.price = price;
        }

        int IComparable<Sweet>.CompareTo(Sweet other)
        {
            return this.caloricity.CompareTo(other.caloricity);
        }

        public override string ToString()
        {
            String info = String.Format(" name - {0}\n weight - {1}\n caloricity - {2}\n price - {3}\n", name, weight, caloricity, price);
            return info;
        }

        public double Price
        {
            get
            {
                return price / 1000 * weight; //цена за 1 грамм умножить на кол-во грамм
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
        }

    }
}
