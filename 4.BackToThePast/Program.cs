using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int haveToLiveToYear = int.Parse(Console.ReadLine());
            for (int i = 1800; i <= haveToLiveToYear; i++)
            {
                if (i % 2 == 0)
                {
                    heritage = heritage - 12000;
                }
                else
                {
                    heritage = heritage - (12000 + (18+(i-1800)) * 50);
                }
            }
            if (heritage >= 0) 
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritage)) ;
            }
        }
    }
}
