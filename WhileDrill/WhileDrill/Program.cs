using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 15)
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            }
            Console.ReadLine();
            int p = 1, n = 5, product;

            do
            {
                product = n * p;
                Console.WriteLine("{0} * {1} = {2}", n, p, product);
                p++;
            } while (p <= 10);

            Console.ReadLine();
        }
    }
}
