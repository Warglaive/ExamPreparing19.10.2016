using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double money = double.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            double pizzaPrice = double.Parse(Console.ReadLine());
            double lasagnaPrice = double.Parse(Console.ReadLine());
            double sandwichPrice = double.Parse(Console.ReadLine());
            double pizzaQuantity = double.Parse(Console.ReadLine());
            double lasagnaQuantity = double.Parse(Console.ReadLine());
            double sandwichQuantity = double.Parse(Console.ReadLine());
            //Algorithm
            double PizzaTotal = (pizzaPrice / rate) * pizzaQuantity; 
            double lasagnaTotal = (lasagnaPrice / rate) * lasagnaQuantity;
            double sandwichTotal = (sandwichPrice / rate) * sandwichQuantity;
            double AbsoluteTotal = PizzaTotal + lasagnaTotal + sandwichTotal;
            //Output
            double leftMoney = money - AbsoluteTotal;
            if (leftMoney < 0)
            {
                leftMoney *= -1;
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: {leftMoney:f2}");
            }
            else if (money>=AbsoluteTotal)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: {leftMoney:f2}");
            }
        }
    }
}
