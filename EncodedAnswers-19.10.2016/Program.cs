using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers_19._10._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int D = 0;
            int C = 0;

            string text = null;
            string result = null;
            int questions = int.Parse(Console.ReadLine());

            for (int i = 0; i < questions; i++)
            {
                uint validNumber = uint.Parse(Console.ReadLine());
                
                if (validNumber % 4 == 2)
                {
                    C++;
                    text = "c";
                    
                }
                else if (validNumber % 4 == 3)
                {
                    D++;
                    text = "d";
                    
                }
                else if (validNumber % 4 == 1)
                {
                    B++;
                    text = "b";
                    
                }
                else if (validNumber % 4 == 0)  
                {
                    A++;
                    text = "a";
                }
                result += text + ' ';
            }
            Console.WriteLine();
            Console.WriteLine("Result: "+result);
            Console.WriteLine();
            Console.WriteLine($"Answer A: {A}");
            Console.WriteLine($"Answer B: {B}");
            Console.WriteLine($"Answer C: {C}");
            Console.WriteLine($"Answer D: {D}");
            Console.WriteLine();
        }
    }
}
