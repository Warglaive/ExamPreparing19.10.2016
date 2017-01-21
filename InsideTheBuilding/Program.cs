using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideTheBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());


            //x1, y1
            if (x1 <= 0 || x1 > h * 3)
            {
                Console.WriteLine("outside");
            }
            else if (y1 < 0 || y1 > h * 4) 
            {
                Console.WriteLine("outside");
            }
            else 
            {
                Console.WriteLine("inside");
            }


            //x2, y2
            if (x2 <= 0 || x2 > h * 3)
            {                                                  //
                Console.WriteLine("outside");                  //
            }                                                  //
            else if (y2 <= 0 || y2 > h * 4)                  //
            {                                                  //
                Console.WriteLine("outside");                  //
            }                                                  //
            else                                               //
            {                                                  //
                Console.WriteLine("inside");                   //
            }



            //x3, y3
            if (x3 <= 0 || x3 > h * 3)
            {
                Console.WriteLine("outside");
            }
            else if (y3 <= 0 || y3 > h * 4)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }



            //x4, y4
            if (x4 <= 0 || x4 > h * 3)                   //
            {                                               //
                Console.WriteLine("outside");               //
            }                                               //
            else if (y4 <= 0 || y4 > h * 4)               //
            {                                               //
                Console.WriteLine("outside");               //
            }                                               //
            else                                            //
            {                                               //
                Console.WriteLine("inside");                //
            }


            //x5, y5                                              
            if (x5 <= 0 || x5 > h * 3)
            {
                Console.WriteLine("outside");
            }
            else if (y5 <= 0 || y5 > h * 4)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
    }
}
