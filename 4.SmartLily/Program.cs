using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachingPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + i * 5;
                    money = money - 1;
                }
                else
                {
                    money = toyPrice + money;
                }
            }
            if (washingMachingPrice<=money)
            {
                money = money - washingMachingPrice;
                Console.WriteLine("Yes! {0:f2}", money);
            }
            else
            {
                washingMachingPrice = washingMachingPrice - money;
                Console.WriteLine("No! {0:f2}", washingMachingPrice);
            }
        }
    }
}
