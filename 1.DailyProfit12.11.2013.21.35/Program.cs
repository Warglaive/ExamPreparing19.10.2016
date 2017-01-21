using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DailyProfit12._11._2013._21._35
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysInMonth = int.Parse(Console.ReadLine());
            double MoneyPerDay = double.Parse(Console.ReadLine());
            double dollarToLev = double.Parse(Console.ReadLine());

            double OneMonthSalary = workingDaysInMonth * MoneyPerDay;
            double yearIncome = OneMonthSalary * 12 + OneMonthSalary * 2.5;
            double taxes = yearIncome * 0.25;
            double clearYearIncome = yearIncome - taxes;
            double avarageGainPerDay = clearYearIncome / 365;

            Console.WriteLine("{0:f2}",avarageGainPerDay*dollarToLev);
        }
    }
}
