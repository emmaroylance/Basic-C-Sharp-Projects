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
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0)
                {
                    Console.WriteLine("Your value must be more than zero");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    int yearBorn = 2020 - userAge;
                    Console.WriteLine("You were born in {0}", yearBorn);
                    Console.ReadLine();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("You entered something incorrectly");
                Console.ReadLine();
            }


        }
    }
}
