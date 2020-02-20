using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill5
{
    class Program
    {
        static void Main(string[] args)
        {
            Math numbers = new Math();
            Console.WriteLine("Please type a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type a number with a decimal in it:");
            double userNumber2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please type a number:");
            //int userNumber3 = Convert.ToInt32(Console.ReadLine());

            int a = 100;
            Console.WriteLine("Before method call, value of a : {0}", a);
            numbers.getValue(out a);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();



            numbers.Math1(userNumber);
            numbers.Math1(userNumber2);


        }
    }
}
