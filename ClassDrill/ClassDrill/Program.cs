using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math numbers = new Math();
            Console.WriteLine("Please type a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            numbers.Addition(userNumber
            );
            numbers.Product(userNumber);
            numbers.Subtraction(userNumber);
        }
    }
}
