using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person1 = new Employee();
            Person1.FirstName = "Sample";
            Person1.LastName = "Student";
            Person1.SayName(Person1.FirstName, Person1.LastName);  
        }
    }
}
