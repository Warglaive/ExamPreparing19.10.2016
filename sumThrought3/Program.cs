using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower(); //Day or night
            double lowestPrice = 0.0;
            //kilometers
            if (kilometers>0)
            {
                if (time == "day") //taxi
                {
                    lowestPrice = 0.70 + (0.79 * kilometers);
                }
                else if (time == "night")
                {
                    lowestPrice = 0.70 + (0.90 * kilometers);
                }
            }
            if (kilometers >= 20) //bus
            {
                if (time == "day" || time == "night")
                {
                    lowestPrice = 0.09 * kilometers;
                }
            }
            if (kilometers >= 100) //train
            {
                if (time == "day" || time == "night")
                {
                    lowestPrice = 0.06 * kilometers;
                }
            }
            Console.WriteLine(lowestPrice);
        }
    }
}
