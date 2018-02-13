using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestation
{
    class Gift
    {
        List<Sweet> sweets;
        const String outputFile = "output.txt";

        public Gift()
        {
            sweets = new List<Sweet>();
        }

        //public List<Sweet> Sweets { get => sweets; set => sweets = value; }

        public void Add(Sweet sweet)
        {
            sweets.Add(sweet);
        }

        public void Sort()
        {
            sweets.Sort();
        }

        public bool ContainFruit()
        {
            bool result = false;
            foreach (Sweet sweet in sweets)
            {
                if (sweet is Fruit)
                {
                    result = true;
                }
            }
            return result;
        }

        public override string ToString()
        {
            String info = String.Empty;
            foreach (Sweet sweet in sweets)
            {
                info += sweet.ToString();
            }
            return info;
        }

        public double GetPrice()
        {
            double price = 0;
            foreach (Sweet sweet in sweets)
            {
                price += sweet.Price;
            }
            return price;
        }

        public int GetWeight()
        {
            int weight = 0;
            foreach (Sweet sweet in sweets)
            {
                weight += sweet.Weight;
            }
            return weight;
        }

        public void DeleteHeavyCandy()
        {
            int i = IndexOfHeavyCandy();
            if (i < 0)
            {
                return;
            }
            sweets.RemoveAt(i);
        }

        int IndexOfHeavyCandy()
        {
            int index = -1;
            int weight = 0;
            for (int i = 0; i < sweets.Count; ++i)
            {
                if (sweets[i] is Candy && weight < sweets[i].Weight)
                {
                    weight = sweets[i].Weight;
                    index = i;
                }
            }
            return index;
        }

        public void WriteToFile()
        {
            StreamWriter sw = new StreamWriter(outputFile);
            foreach (Sweet sweet in sweets)
            {
                sw.WriteLine(sweet.ToString().Replace("\n", ","));
            }
            sw.WriteLine("Weight: " + GetWeight());
            sw.WriteLine("Price: " + GetPrice());
            sw.Close();
        }

    }
}
