using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment28._10._2016._23._30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int range = 0;

            bool inside = (point >= first && point <= second || (point <= first && point >= second));
            //((point >= first && point <= second || (point <= first && point >=second))
            if (inside == true)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            //SecondPrint-SecondCheck
            if (point - second < point - first)
            {
                range = Math.Abs(point - first);
                if (range < 0)
                {
                    range = range * -1;
                }
            }
            else
            {
                range = Math.Abs(point - second);
                if (range < 0)
                {
                    range = range * -1;
                }
            }
            if (range < 0)
            {
                range *= -1;
            }
            Console.WriteLine(range);
        }
    }
}

//if( first || second < 0)
//first *=-1 || second *=-1;