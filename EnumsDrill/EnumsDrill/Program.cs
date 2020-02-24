using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string currentday = Console.ReadLine();
                days day;

                if (Enum.TryParse<days>(currentday, out day))
                {
                    Console.WriteLine("Good job.  Today is " + currentday);
                    Console.ReadLine();
                }
                else
                {
                    throw new OverflowException(); 
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }

        public enum days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}