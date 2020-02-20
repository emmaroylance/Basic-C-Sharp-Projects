using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDrill
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName(string FirstName, string LastName)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName );
        }
    }
}
