using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double bullshit = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double bullshit1 = double.Parse(Console.ReadLine());
            double sideA = x3 - x2;
            double High = y1 - y2;
            double Area = sideA * High / 2.0;
            if (Area < 0)
            {
                Area *= -1;
            }
            Console.WriteLine(Area);
         }
    }
}
 