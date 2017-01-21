using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int threatened = 0;
            int unThreatened = 0;
            for (int day = 1; day <= period; day++)
            {
                int patients = int.Parse(Console.ReadLine());
                if ((day % 3 == 0) && (unThreatened > threatened))
                {
                    doctors++;
                }
                if (patients > doctors) 
                {
                    threatened = threatened + doctors; // zashtoto 7 lekari lekuvat 7 pacienta.
                    unThreatened = unThreatened + patients - doctors;
                }
                else
                {
                    threatened = threatened + patients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", threatened);
            Console.WriteLine("Untreated patients: {0}.", unThreatened);
        }
    }
}
