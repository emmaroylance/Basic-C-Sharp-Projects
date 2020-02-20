using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill5
{
    public static class Math2
    {
        public static int Operations(string userInput3)
        {
            int integer = Convert.ToInt32(userInput3);
            int quotient = integer / 2;
            Console.WriteLine(integer + " divided by 2 equals " + quotient);
            return quotient;
        }
    }
}
