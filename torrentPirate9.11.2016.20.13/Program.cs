using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torrentPirate9._11._2016._20._13
{
    class Program
    {
        static void Main(string[] args)
        {
            double downloadDATA = double.Parse(Console.ReadLine());
            double cinemaCost = double.Parse(Console.ReadLine());
            double wifeSpending = double.Parse(Console.ReadLine());

            //
            double downloadTimx = downloadDATA / 2 / 60 / 60;
            double priceForDownload = downloadTimx * wifeSpending;
            double numberOfMoviesDownloaded = downloadDATA / 1500;
            double cinemaPrice = numberOfMoviesDownloaded * cinemaCost;

            if (cinemaPrice>priceForDownload)
            {
                Console.WriteLine("mall -> {0:f2}lv", priceForDownload);

            }
            else if (priceForDownload==cinemaPrice)
            {
                Console.WriteLine("mall -> {0:f2}lv", priceForDownload);
            }
            else
            {
                Console.WriteLine("cinema -> {0:f2}lv", cinemaPrice);
            }
            // Console.WriteLine("cinema -> {0:f2}" ,cinemaPrice);
            // Console.WriteLine("mall -> {0:f2}", priceForDownload);

        }
    }
}
