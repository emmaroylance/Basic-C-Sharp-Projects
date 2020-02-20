using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill2
{
    class Math
    {
        public int Operations(int userInput1)
        {
            int addition = userInput1 + 10;
            Console.WriteLine(userInput1 + " plus 10 equals " + addition);
            return addition;
        }

        public double Operations(double userInput2)
        {
            double product = userInput2 * 30;
            Console.WriteLine(userInput2 + " multiplied by 30 equals " + product);
            return product;
        }

        public int Operations(string userInput3)
        {
            int integer = Convert.ToInt32(userInput3);
            int quotient = integer / 2;
            Console.WriteLine(integer + " divided by 2 equals " + quotient);
            return quotient;
        }
    }
}
