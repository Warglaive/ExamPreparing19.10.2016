using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11._2016._21._52InTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHR = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHR = int.Parse(Console.ReadLine());
            int arriveMIN = int.Parse(Console.ReadLine());
            int LateHrResult = 0;
            int LateMinResult = 0;
            int OnTimeHrResult = 0;
            int OntimeMinResult = 0;
            int EarlyHrResult = 0;
            int EarlyMinResult = 0;

            if (arriveMIN <= 0)
            {
                arriveMIN = 60;
            }
            else if (examMin <= 0)
            {
                examMin = 60;
            }
            //Clock logic.

            if (examHR > 23)
            {
                examHR = 00;
            }
            else if (arriveHR > 23) 
            {
                arriveHR = 00;
            }
            if (examMin > 60)
            {
                examHR++;
            }
            else if (arriveMIN > 60) 
            {
                arriveMIN++;
            }
            //Late/Early/OnTime Algorithm.
            if (arriveHR > examHR)
            {
                LateHrResult = arriveHR - examHR;
                LateMinResult = arriveMIN - examMin;
                Console.WriteLine($"Late {LateHrResult}:{LateMinResult} hours after the start");
            }
            else if (arriveHR >= examHR && arriveMIN > examMin)
            {
                LateHrResult = arriveHR - examHR;
                LateMinResult = arriveMIN - examMin;
                Console.WriteLine($"Late {LateHrResult}:{LateMinResult} hours after the start");
            }
            if (arriveHR == examHR && arriveMIN > examMin - 30) //<-fix
            {

                if (arriveMIN <= 0)
                {
                    arriveMIN = 60;
                }
                else if (examMin <= 0)
                {
                    examMin = 60;
                }
                LateHrResult = (arriveHR - examHR);
                LateMinResult = (arriveMIN - examMin);
                Console.WriteLine("On Time");
                Console.WriteLine($"{LateMinResult} minutes before the start");
            }
            if (arriveMIN > examMin - 31)
            {
                if (arriveMIN < 0)
                {
                    arriveMIN = 0;
                }
                else if (examMin < 0)
                {
                    examMin = 0;
                }
                Console.WriteLine("Early");
                Console.WriteLine($"{LateMinResult} minutes before the start");
            }
            else if (arriveHR < examHR) 
            {
                if (arriveMIN < 0)
                {
                    arriveMIN = 0;
                }
                else if (examMin < 0)
                {
                    examMin = 0;
                }
                Console.WriteLine("Early");
                Console.WriteLine($"{LateMinResult} minutes before the start");
            }
        }
    }
}
//UNFINISHED.