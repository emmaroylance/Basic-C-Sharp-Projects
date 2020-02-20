using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Math numbers = new Math();
            Console.WriteLine("Please type a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type a second number: ");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            numbers.Math1(userNumber, userNumber2);
        }
    }
}
