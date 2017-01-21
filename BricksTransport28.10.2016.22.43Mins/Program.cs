using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricksTransport28._10._2016._22._43Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            double bricksNumber = double.Parse(Console.ReadLine());
            double workersCount = double.Parse(Console.ReadLine());
            double cartCapacity = double.Parse(Console.ReadLine());
            double courseMin = Math.Ceiling(bricksNumber / workersCount / cartCapacity);
            Console.WriteLine(courseMin);
        }
    }
}