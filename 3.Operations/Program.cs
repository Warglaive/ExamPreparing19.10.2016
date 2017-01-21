using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operationChar = Console.ReadLine();
            double result = 0;
            if (operationChar == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, operationChar, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, operationChar, n2, result);
                }
            }
            else if (operationChar == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, operationChar, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, operationChar, n2, result);
                }
            }
            else if (operationChar == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, operationChar, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, operationChar, n2, result);
                }
            }
            else if (operationChar == "/")
            {
                if (n2==0 || n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 / n2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", n1, operationChar, n2, result);
                }
            }
            else if (operationChar == "%")
            {
                if (n2 == 0 || n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, operationChar, n2, result);
                }
            }
        }
    }
}
