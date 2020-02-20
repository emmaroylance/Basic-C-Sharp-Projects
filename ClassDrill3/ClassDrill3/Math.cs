using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class Math
    {
        //public int Operate(int userValue, userValue2)
        //{
        //    return userValue + 5 + userValue2;
        //}

        public int Operate(int userValue, int userValue2int = 0)
        {
            int addition = userValue + userValue2int + 4;
            Console.WriteLine(userValue + userValue2int + " plus 4 equals " + addition);
            return addition;
        }
    }
}
