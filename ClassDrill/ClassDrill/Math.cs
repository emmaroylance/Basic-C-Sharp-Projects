using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    public class Math
    {

        public int Product(int userNumber)
        {
            int product = userNumber * 50;
            Console.WriteLine(userNumber + " multiplied by 50 equals " + product);
            return product;
        }

        public int Addition(int userNumber)
        {
            int addition = userNumber + 25;
            Console.WriteLine(userNumber + " plus 25 equals " + addition);
            return addition;
        }

        public int Subtraction(int userNumber)
        {
            int subtraction = userNumber - 2;
            Console.WriteLine(userNumber + " minus 2 equals " + subtraction);
            return subtraction;
        }
    }
}
