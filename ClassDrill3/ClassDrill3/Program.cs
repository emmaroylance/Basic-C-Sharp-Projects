using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math numbers = new Math();
            Console.WriteLine("Please type a number: ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please type a number--optional:");
            //int userValue2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number--optional");
            string userValue2 = Console.ReadLine();
            if (userValue2.Length > 0)
            {
                int userValue2int = Convert.ToInt32(userValue2);
                numbers.Operate(userValue, userValue2int);
            }
            else
            { 
                numbers.Operate(userValue);
            }
        }

        //static void Main(string[] args)
        //{
        //    Math operatorObject = new Math();
        //    int userValue2;
        //    int result;
        //    Console.WriteLine("Pick a number:");
        //    int userValue = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Pick another number--optional");
        //    if (int.TryParse(Console.ReadLine(), out userValue2))
        //    {
        //        result = operatorObject.Operate(userValue, userValue2);
        //    }
        //    else
        //    {
        //       result =  Math.Operate(userValue);
        //    }
        //}
    }
}
