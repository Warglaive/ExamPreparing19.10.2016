using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3NumbersSum3._11._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine()); //A<=B
            int C = int.Parse(Console.ReadLine());
            if (A + B == C)
            {
                Console.WriteLine($"{A} + {B} = {C}");
            }
            if (B + A == C)
            {
                Console.WriteLine($"{B} + {A} = {C}");
            }                                                     
            if (B + C == A)
            {
                Console.WriteLine($"{B} + {C} = {A}");
            }
            if (C + B == A)
            {
                Console.WriteLine($"{C}+{B} = {A}");
            }                                                      
            if (C + A == B)
            {
                Console.WriteLine($"{C} + {A} = {B}");
            }
            if (A + C == B)
            {
                Console.WriteLine($"{A}+{C}={B}");                    
            }                                           
            else
            {                                                         
                Console.WriteLine("No");
            }
        }
    }
}
                                                                      