using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number:");
            string firstNumber = Console.ReadLine();
            int firstNum = Convert.ToInt32(firstNumber);
            int product = firstNum * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Please type a number:");
            string secondNumber = Console.ReadLine();
            int secondNum = Convert.ToInt32(secondNumber);
            int addition = secondNum + 25;
            Console.WriteLine(addition);
            Console.ReadLine();

            Console.WriteLine("Please type a number:");
            string thirdNumber = Console.ReadLine();
            int thirdNum = Convert.ToInt32(thirdNumber);
            double quotient = thirdNum / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine("Please type a number:");
            string fourthNumber = Console.ReadLine();
            int fourthNum = Convert.ToInt32(fourthNumber);
            bool greaterThanFifty = fourthNum > 50;
            Console.WriteLine(greaterThanFifty);
            Console.ReadLine();

            Console.WriteLine("Please type a number:");
            string fifthNumber = Console.ReadLine();
            int fifthNum = Convert.ToInt32(fifthNumber);
            int remainder = fifthNum % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
