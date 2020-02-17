using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \r\nPerson 1");
            Console.ReadLine();
            Console.WriteLine("Please enter the hourly rate for Person 1: ");
            string hourlyRate1 = Console.ReadLine();
            int hourly1 = Convert.ToInt32(hourlyRate1);

            Console.WriteLine("Please enter the hours worked per week for Person 1: ");
            string weeklyHours1 = Console.ReadLine();
            int hoursPerWeek1 = Convert.ToInt32(weeklyHours1);

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Please enter the hourly rate for Person 2: ");
            string hourlyRate2 = Console.ReadLine();
            int hourly2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Please enter the hours worked per week for Person 2: ");
            string weeklyHours2 = Console.ReadLine();
            int hoursPerWeek2 = Convert.ToInt32(weeklyHours2);

            int Annual1 = hourly1 * 52 * hoursPerWeek1;
            int Annual2 = hourly2 * 52 * hoursPerWeek2;

            Console.WriteLine("Annual salary of person 1: " + Annual1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of person 1: " + Annual2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than person 2?");
            bool whosGreater = Annual1 > Annual2;
            Console.WriteLine(whosGreater);
            Console.ReadLine();








        }
    }
}
