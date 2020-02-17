using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package Express. Please follow the instructions below.\r\n Please enter te package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
                if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter the width of the package: ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the height of the package: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the length of the package:");
                    int length = Convert.ToInt32(Console.ReadLine());
                    if (width * height* length > 50)
                        {
                        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day");
                        Console.ReadLine();
                        return;
                        }
                    else
                    {
                        int dimensions = width * height * length * weight / 100;
                        Console.WriteLine("Your estimated total for shipping this package is: $" + dimensions + ". \r\nThank you!");
                        Console.ReadLine();
                    }
                }
        }
    }
}
