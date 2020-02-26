using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDrill
{
    public class Names
    {
        public string lastName { get; set; }
        public string firstName { get; set; }

        public void People(string firstNameOfPeople, string lastNameOfPeople)
        {
            lastName = lastNameOfPeople;
            firstName = firstNameOfPeople;
            Console.WriteLine(firstName + " " + lastName);
        }

        public void People(string firstNameOfPeople) : this(firstNameOfPeople, "Smith" )
        {
        }

    }
}
