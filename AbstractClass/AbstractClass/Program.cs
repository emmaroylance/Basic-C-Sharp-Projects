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
            IQuittable employee = new Employee();
            Console.WriteLine(Person1.FirstName + " " + Person1.LastName +  ": " + employee.IsActive);
            employee.Quit();
            Console.WriteLine(Person1.FirstName + " " + Person1.LastName + ": " + employee.IsActive);
            //Console.WriteLine("{0} {1} is an active employee: {2}", employee.FirstName, employee.LastName, employee.IsActive);
            Console.ReadLine();
        }
    }
}
