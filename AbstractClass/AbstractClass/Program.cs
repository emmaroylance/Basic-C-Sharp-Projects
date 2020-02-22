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

            Employee<string> stringsOfThings = new Employee<string>();
            Employee<int> intsOfThings = new Employee<int>();
            stringsOfThings.things = new List<string>() {"DOB", "Address", "Phone Number", "Years Employed"};
            intsOfThings.things = new List<int>() {1, 2, 3, 4, 5};
  

            for (int j = 0; j < stringsOfThings.things.Count; j++)
            {
                Console.WriteLine(stringsOfThings.things[j]);
            }

            for (int i = 0; i < intsOfThings.things.Count; i++)
            {
                Console.WriteLine(intsOfThings.things[i]);
            }

            Console.ReadLine();

            //Employee Person1 = new Employee();
            //Employee Person2 = new Employee();
            //Employee isequals = new Employee();
            //Person1.FirstName = "Sample";
            //Person1.LastName = "Student";
            //Person1.Id = 1;
            //Person2.FirstName = "John";
            //Person2.LastName = "Smith";
            //Person2.Id = 2;


            //Person1.SayName();
            //Console.ReadLine();
            //IQuittable employee = new Employee();
            //Console.WriteLine(Person1.FirstName + " " + Person1.LastName +  ": " + employee.IsActive);
            //employee.Quit();
            //Console.WriteLine(Person1.FirstName + " " + Person1.LastName + ": " + employee.IsActive);
            //Console.WriteLine(Person1 == Person2);
            //Console.ReadLine();
        }
    }
}
