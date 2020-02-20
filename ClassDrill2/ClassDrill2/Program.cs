using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math numbers = new Math();
            Console.WriteLine("Please type a number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type a number with a decimal: ");
            double userInput2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type a number: ");
            string userInput3 = Console.ReadLine();
            Console.ReadLine();

            numbers.Operations(userInput1);
            numbers.Operations(userInput2);
            numbers.Operations(userInput3);
        }
        
    }
}
