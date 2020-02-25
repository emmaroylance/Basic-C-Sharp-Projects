using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee()
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Thompson"
            });
            emplist.Add(new Employee()
            {
                Id = 2,
                FirstName = "Joe",
                LastName = "Thompson"
            });
            emplist.Add(new Employee()
            {
                Id = 3,
                FirstName = "Joe",
                LastName = "Romney"
            });
            emplist.Add(new Employee()
            {
                Id = 4,
                FirstName = "Sally",
                LastName = "Birch"
            });
            emplist.Add(new Employee()
            {
                Id = 5,
                FirstName = "Thomas",
                LastName = "Riddle"
            });
            emplist.Add(new Employee()
            {
                Id = 6,
                FirstName = "Harry",
                LastName = "Potter"
            });
            emplist.Add(new Employee()
            {
                Id = 7,
                FirstName = "Ronald",
                LastName = "Weasley"
            });
            emplist.Add(new Employee()
            {
                Id = 8,
                FirstName = "Hermione",
                LastName = "Granger"
            });
            emplist.Add(new Employee()
            {
                Id = 9,
                FirstName = "Draco",
                LastName = "Malfoy"
            });
            emplist.Add(new Employee()
            {
                Id = 10,
                FirstName = "Albus",
                LastName = "Dumbledore"
            });
            // Create empty list

            List<Employee> emplist2 = new List<Employee>();


            foreach (var employee in emplist)
            {
                if (employee.FirstName == "Joe")
                {
                    emplist2.Add(employee);
                }

            }


            List<Employee> emplist3 = emplist.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> emplist4 = (emplist.Where(x => x.Id > 5).ToList());

            foreach (var employee in emplist3)
            {
                Console.WriteLine(employee.FirstName);
            }

            foreach (var employee in emplist4)
            {
                Console.WriteLine(employee.FirstName);
            }

            foreach (var employee in emplist2)
            {
                Console.WriteLine(employee.FirstName);
            }



        }

    }
}
