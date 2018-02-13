using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Gift gift = new Gift();
                StreamReader sr = new StreamReader(args[0]);
                String readed;
                while ((readed = sr.ReadLine()) != null)
                {
                    List<String> dataOfSweet = GetParams(readed);
                    if (dataOfSweet[0] == "c")
                    {

                        gift.Add(new Candy(dataOfSweet[1], Int32.Parse(dataOfSweet[2]), Int32.Parse(dataOfSweet[3]),
                            Double.Parse(dataOfSweet[4]), Int32.Parse(dataOfSweet[5]), (Stuffing)Enum.Parse(typeof(Stuffing),dataOfSweet[6])));
                    }
                    else if (dataOfSweet[0] == "w")
                    {
                        gift.Add(new Wafer(dataOfSweet[1], Int32.Parse(dataOfSweet[2]), Int32.Parse(dataOfSweet[3]),
                            Double.Parse(dataOfSweet[4]), (Taste)Enum.Parse(typeof(Taste),dataOfSweet[5]), Boolean.Parse(dataOfSweet[6])));
                    }
                    else if( dataOfSweet[0] == "f")
                    {
                        gift.Add(new Fruit(dataOfSweet[1], Int32.Parse(dataOfSweet[2]), Int32.Parse(dataOfSweet[3]),
                            Double.Parse(dataOfSweet[4]), Int32.Parse(dataOfSweet[5]), Int32.Parse(dataOfSweet[6])));
                    }
                }

                //2. если нет фруктов
                if (!gift.ContainFruit())
                {
                    gift.Add(new Fruit("Limon", 40, 30, 7, 70, 2));
                    gift.Add(new Fruit("Banana", 55, 35, 6, 30, 5));
                }
                //4 выполнить сортировку
                Console.WriteLine("Before sorting:");
                Console.WriteLine(gift);

                gift.Sort();
                Console.WriteLine("After sorting");
                Console.WriteLine(gift);

                //5. вычислить стоимость
                Console.WriteLine("Price:");
                Console.WriteLine(gift.GetPrice());

                //3. вычислить вес подарка
                Console.WriteLine("Weight:");
                int weight = gift.GetWeight();
                Console.WriteLine(weight + " gramme");
                if (weight > 1000)
                {
                    gift.DeleteHeavyCandy();
                    Console.WriteLine("After deleting\n" + gift.GetWeight() + " gramme");
                    Console.WriteLine(gift);

                }
                //6. записать в файл
                gift.WriteToFile();


                
            }
            Console.ReadKey();
        }

        static List<String> GetParams(String s)
        {
            return new List<String>(s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
