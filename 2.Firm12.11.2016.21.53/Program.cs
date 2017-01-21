using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Money._11._2016._21._53
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinToLeva = bitCoin * 1168.0;

            double yuanToDollar = yuan * 0.15;

            double yuanToLeva = yuanToDollar * 1.76;

            double total = bitcoinToLeva + yuanToLeva;

            double totalToEURO = total / 1.95;
            double Euro;
            Euro = totalToEURO * comission/100;

            Console.WriteLine(totalToEURO - Euro);
        }
    }
}
