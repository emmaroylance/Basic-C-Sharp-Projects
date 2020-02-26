using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is {0}",currentTime);
            Console.WriteLine("Please enter a number: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + {1} hours = {2}", currentTime, X, currentTime.AddHours(X));
            Console.ReadLine();
        }
    }
}
