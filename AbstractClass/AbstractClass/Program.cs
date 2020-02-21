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
            Employee Person2 = new Employee();
            Employee isequals = new Employee();
            Person1.FirstName = "Sample";
            Person1.LastName = "Student";
            Person1.Id = 1;
            Person2.FirstName = "John";
            Person2.LastName = "Smith";
            Person2.Id = 2;


            Person1.SayName();
            Console.ReadLine();
            IQuittable employee = new Employee();
            Console.WriteLine(Person1.FirstName + " " + Person1.LastName +  ": " + employee.IsActive);
            employee.Quit();
            Console.WriteLine(Person1.FirstName + " " + Person1.LastName + ": " + employee.IsActive);
            Console.WriteLine(Person1 == Person2);
            Console.ReadLine();
        }
    }
}
