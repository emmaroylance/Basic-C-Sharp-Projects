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

        public Names(string firstNameOfPeople, string lastNameOfPeople)
        {
            lastName = lastNameOfPeople;
            firstName = firstNameOfPeople;
            Console.WriteLine(firstName + " " + lastName);
            return;
        }

        public Names(string firstNameOfPeople) : this(firstNameOfPeople, "Smith" )
        {
        }

    }
}
