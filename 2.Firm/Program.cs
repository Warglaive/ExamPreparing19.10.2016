using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double RequiredHours = double.Parse(Console.ReadLine());
            int firmHasDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int overtimeHR = 2;


            double daysToHours = firmHasDays * 8;
            double training10Percent = daysToHours * 0.90;
            double overtimeworking = workers * firmHasDays * overtimeHR;
            double total = Math.Floor(training10Percent + overtimeworking); //ranno zakruglqne;

            if (total>=RequiredHours)
            {
                total=total - RequiredHours;
                Console.WriteLine("Yes!{0:f0} hours left.", total);
            }
            else
            {
                RequiredHours = RequiredHours - total;
                Console.WriteLine("Not enough time!{0:f0} hours needed.", RequiredHours);
            }
        }
    }
}
