using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double budgetSeason = 0;
            string homeType = null;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    homeType = "Camp";
                    budgetSeason = budget * 0.70;
                    budget = budget - budgetSeason;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("{0} - {1:f2}", homeType, budget);
                }
                else if (season == "winter")
                {
                    homeType = "Hotel";
                    budgetSeason = budget * 0.30;
                    budget = budget - budgetSeason;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("{0} - {1:f2}", homeType, budget);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    homeType = "Camp";
                    budgetSeason = budget * 0.60;
                    budget = budget - budgetSeason;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("{0} - {1:f2}", homeType, budget);
                }
                else if (season == "winter")
                {
                    homeType = "Hotel";
                    budgetSeason = budget * 0.20;
                    budget = budget - budgetSeason;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("{0} - {1:f2}", homeType, budget);
                }
            }
            else if (budget > 1000) 
            {
                homeType = "Hotel";
                budgetSeason = budget * 0.10;
                budget = budget - budgetSeason;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("{0} - {1:f2}", homeType, budget);
            }
        }
    }
}
