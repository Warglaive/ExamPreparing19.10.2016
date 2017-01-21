using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double discountStudio = 0;
            double discountApartament = 0;
            double studio = 0;
            double apartament = 0;
            double studioPerNight = 0;
            double apartamentPerNight = 0;
            if (month == "May" || month == "October")
            {
                studio = 50;
                apartament = 65;
                studioPerNight = studio * nightsCount;
                apartamentPerNight = apartament * nightsCount;

                if (nightsCount > 7 && nightsCount <= 14)
                {
                    discountStudio = studio * 0.95;
                    studioPerNight = discountStudio * nightsCount;
                }
                else if (nightsCount > 14)
                {
                    discountStudio = studio * 0.70;
                    studioPerNight = discountStudio * nightsCount;
                    discountApartament = apartament * 0.90;
                    apartamentPerNight = discountApartament * nightsCount;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartament = 68.70;
                studioPerNight = studio * nightsCount;
                apartamentPerNight = apartament * nightsCount;

                if (nightsCount > 14)
                {
                    discountStudio = studio * 0.80;
                    studioPerNight = discountStudio * nightsCount;
                    discountApartament = apartament * 0.90;
                    apartamentPerNight = discountApartament * nightsCount;
                }
            }
            else if (month == "July" || month == "August") 
            {
                studio = 76;
                apartament = 77;
                studioPerNight = studio * nightsCount;
                apartamentPerNight = apartament * nightsCount;
                if (nightsCount > 14) 
                {
                    discountApartament = apartament * 0.90;
                    apartamentPerNight = discountApartament * nightsCount;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartamentPerNight);
            Console.WriteLine("Studio: {0:f2} lv.", studioPerNight);
        }
    }
}
