using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person1 = new Employee();
            Person1.FirstName = "Sample";
            Person1.LastName = "Student";
            Person1.SayName();
            Console.ReadLine();
        }
    }
}
