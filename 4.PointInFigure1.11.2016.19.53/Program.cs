using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PointInFigure1._11._2016._19._53
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x < 4 && x > 10 && y < -3 && y > 1)
            {
                Console.WriteLine("out");
            }
            else if (x < 2 && x > 12 && y > 1 && y < -3)
            {
                Console.WriteLine("out");
            }
            else if (x > 10 && x < 4 && y < -3 && y > 1)
            {
                Console.WriteLine("out");
            }
            else if (x > 10 && x < 4 && y > 1 && y < -3) 
            {
                Console.WriteLine("out");
            }
            else if (x > 12 && x<4 && y < -3&&y>1)
            {
                Console.WriteLine("out");
            }
            if (x > 12 && x < 2 && y > 1) 
            {
                Console.WriteLine("out");
            }
            else
            {
                Console.WriteLine("in");
            }//Ne raboti.
        }
    }
}
