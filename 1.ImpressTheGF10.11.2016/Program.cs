using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ImpressTheGF10._11._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double rubles = double.Parse(Console.ReadLine());
            double dollars = double.Parse(Console.ReadLine());
            double euro = double.Parse(Console.ReadLine());
            double levaBSite = double.Parse(Console.ReadLine());
            double levaMSite = double.Parse(Console.ReadLine());

            double rublesInLeva = (rubles / 100) *3.5;
            double dollarInLeva = dollars * 1.5;
            double euroInLeva = euro * 1.95;
            double BsiteNewValue = levaBSite / 2;

            Console.WriteLine("{0:f2}", Math.Ceiling(Math.Max(rublesInLeva, Math.Max(dollarInLeva, Math.Max(euroInLeva, Math.Max(BsiteNewValue, levaMSite))))));
        }
    }
}
