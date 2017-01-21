using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram6._11._2016._13._54
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersCount = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            double counter = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                double newNumbers = double.Parse(Console.ReadLine());
                counter++;
                if (newNumbers<200)
                {
                
                    p1++;
                }
                else if (newNumbers<400)
                {
               
                    p2++;
                }
                else if (newNumbers<600)
                {
            
                    p3++;
                }
                else if (newNumbers<800)
                {
                 
                    p4++;
                }
                else if (newNumbers>=800)
                {
            
                    p5++;
                }
            }
            Console.WriteLine("{0:f2}%", p1*100/counter);
            Console.WriteLine("{0:f2}%", p2*100/counter);
            Console.WriteLine("{0:f2}%", p3*100/counter);
            Console.WriteLine("{0:f2}%", p4*100/counter);
            Console.WriteLine("{0:f2}%", p5*100/counter);
        }
        //Logic Explanation: p1(if p1==2) *100 = 200
        //200/counter(3 - 3 puti se vurti for cikala) 200/3==66.66;
        //ako se zavurti 4 puti - stava 50%, zashtoto vliza 4 puti v for cikala.
    }
}
