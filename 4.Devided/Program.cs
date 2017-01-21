using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var widthCm = double.Parse(Console.ReadLine()) * 100;
            var heightCm = double.Parse(Console.ReadLine()) * 100 - 100;

            var deskWidthCm = 120.0;
            var deskHeight = 70.0;
            var lostDesks = 3;

            var desksPerRow = (int)(heightCm / deskHeight);
            var desksPerColumn = (int)(widthCm / deskWidthCm);

            var totalDesks = desksPerRow * desksPerColumn - lostDesks;

            Console.WriteLine(totalDesks);
            Console.WriteLine($"{totalDesks} ");
        }
    }
}
