using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (userAge <= 0)
                {
                    throw new ArgumentException();
                }

                int yearBorn = 2020 - userAge;
                Console.WriteLine("You were born in {0}", yearBorn);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your value must be more than zero");
                Console.ReadLine();
                return;
            }

            catch (FormatException)
            {
                Console.WriteLine("You entered something incorrectly");
                Console.ReadLine();
            }


        }
    }
}
