using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you qualify for car insurance?\r\nPlease answer the following questions:");
            Console.ReadLine();
            
            Console.WriteLine("What is your age?");
            string ageApplicant = Console.ReadLine();
            int ageApp = Convert.ToInt32(ageApplicant);

            Console.WriteLine("Have you ever had a DUI? Please type \"true\" or \"false\"");
            string DUIyesOrNo = Console.ReadLine();
            bool DUI = System.Convert.ToBoolean(DUIyesOrNo);

            Console.WriteLine("How many speeding tickets do you have?");
            string AmountOfSpeedingTickets = Console.ReadLine();
            int NumOfSpeedingTickets = Convert.ToInt32(AmountOfSpeedingTickets);

            bool isQualified = (ageApp > 15 && DUI != true &&NumOfSpeedingTickets < 4);

            Console.WriteLine(isQualified);
            Console.ReadLine();



        }
    }
}
