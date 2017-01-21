
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Practice
{
    class Program
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) //upper part
            {
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.Write(new string('.', (2 * n) - i * 2));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("#");
                Console.Write(new string('.', (2 * n) - i * 2));
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.WriteLine();
            }
            for (int i = 0; i <= n; i++) //middle part
            {
                Console.Write(new string('.', (i * 2) + 1));
                Console.Write("#");
                Console.Write(new string('~', n - i));
                Console.Write("#");
                Console.Write(new string('.', (n * 2) - i * 2));
                Console.Write("#");
                Console.Write(new string('~', n - i));
                Console.Write("#");
                Console.Write(new string('.', (i * 2) + 1));
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++) //stem
            {
                Console.Write(new string('.', n * 2 + 2));
                Console.Write("##");
                Console.Write(new string('.', n * 2 + 2));
                Console.WriteLine();
            }
        }
    }
}