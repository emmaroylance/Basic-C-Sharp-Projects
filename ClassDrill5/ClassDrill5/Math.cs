using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill5
{
    class Math
    {
        public void getValue(out int x)
        {
            int temp = 10;
            x = temp;
        }
        public void Math1(int userNumber)
        {
            int division = userNumber / 2;
            Console.WriteLine(userNumber + " divided by 2 equals " + division);
            Console.ReadLine();
        }

        public void Math1(double userNumber2)
        {
            double division = userNumber2 / 3;
            Console.WriteLine(userNumber2 + " divided by 3 equals " + division);
            Console.ReadLine();
        }
    }
}
