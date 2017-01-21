using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int peoplesCount = int.Parse(Console.ReadLine());
            double transportPrice = 0;
            double moneyLeft = 0;
            double normalTicketPerPerson = 249.99 * peoplesCount;
            double VIPTicketPerPerson = 499.99 * peoplesCount;
            if (peoplesCount >= 1 && peoplesCount <= 4)
            {
                transportPrice = budged * 0.75;
                moneyLeft = budged - transportPrice;
                if (category=="normal")
                {
                    if (normalTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - normalTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (normalTicketPerPerson > moneyLeft)
                    {
                        normalTicketPerPerson = normalTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", normalTicketPerPerson);
                    }
                }
                else if (category=="vip")
                {
                    if (VIPTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - VIPTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (VIPTicketPerPerson > moneyLeft)
                    {
                        VIPTicketPerPerson = VIPTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPTicketPerPerson);
                    }
                }
            }
            else if (peoplesCount >= 5 && peoplesCount <= 9)
            {
                transportPrice = budged * 0.60;
                moneyLeft = budged - transportPrice;
                if (category=="normal")
                {
                    if (normalTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - normalTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (normalTicketPerPerson > moneyLeft)
                    {
                        normalTicketPerPerson = normalTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", normalTicketPerPerson);
                    }
                }
                else if (category=="vip")
                {
                    if (VIPTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - VIPTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (VIPTicketPerPerson > moneyLeft)
                    {
                        VIPTicketPerPerson = VIPTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPTicketPerPerson);
                    }
                }
            }
            else if (peoplesCount >= 10 && peoplesCount <= 24) 
            {
                transportPrice = budged * 0.50;
                moneyLeft = budged - transportPrice;
                if (category == "normal")
                {
                    if (normalTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - normalTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (normalTicketPerPerson > moneyLeft)
                    {
                        normalTicketPerPerson = normalTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", normalTicketPerPerson);
                    }
                }
                else if (category == "vip")
                {
                    if (VIPTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - VIPTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (VIPTicketPerPerson > moneyLeft)
                    {
                        VIPTicketPerPerson = VIPTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPTicketPerPerson);
                    }
                }
            }
            else if (peoplesCount >= 25 && peoplesCount <= 49)      
            {
                transportPrice = budged * 0.40;
                moneyLeft = budged - transportPrice;
                if (category == "normal")
                {
                    if (normalTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - normalTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (normalTicketPerPerson > moneyLeft)
                    {
                        normalTicketPerPerson = normalTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", normalTicketPerPerson);
                    }
                }
                else if (category == "vip")
                {
                    if (VIPTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - VIPTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (VIPTicketPerPerson > moneyLeft)
                    {
                        VIPTicketPerPerson = VIPTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPTicketPerPerson);
                    }
                }
            }
            else if (peoplesCount >=50)     
            {
                transportPrice = budged * 0.25;
                moneyLeft = budged - transportPrice;
                if (category == "normal")
                {
                    if (normalTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - normalTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (normalTicketPerPerson > moneyLeft)
                    {
                        normalTicketPerPerson = normalTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", normalTicketPerPerson);
                    }
                }
                else if (category == "vip")
                {
                    if (VIPTicketPerPerson <= moneyLeft)
                    {
                        moneyLeft = moneyLeft - VIPTicketPerPerson;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else if (VIPTicketPerPerson > moneyLeft)
                    {
                        VIPTicketPerPerson = VIPTicketPerPerson - moneyLeft;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPTicketPerPerson);
                    }
                }
            }
        }
    }
}
