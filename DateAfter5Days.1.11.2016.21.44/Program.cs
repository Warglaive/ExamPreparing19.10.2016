using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days._1._11._2016._21._44
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            var year = 2015; //current year. 
            DateTime firstDate = new DateTime(year, month, days);
            DateTime secondDate = firstDate.AddDays(5);

            Console.WriteLine(secondDate.ToString("d.MM.yyyy"));
        }
    }
}
