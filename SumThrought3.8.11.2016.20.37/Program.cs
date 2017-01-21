using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumThrought3._8._11._2016._20._37
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int Numbers = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    sum1 = sum1 + Numbers;
                }
                else if (i % 3 == 1)
                {
                    sum2 = sum2 + Numbers;
                }
                else if (i % 3 == 2) 
                {
                    sum3 = sum3 + Numbers;
                }
            }
            Console.WriteLine("sum1 {0}", sum2);
            Console.WriteLine("sum2 {0}", sum3);
            Console.WriteLine("sum3 {0}", sum1);
        }
    }
}
