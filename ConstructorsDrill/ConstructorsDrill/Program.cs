using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDrill
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string name = "Emma";
            var listOfNames = new List<string>() { name, "Tyler", "Kent", "Karalee" };


        Console.WriteLine("Please enter your first name: ");
        string firstNameOfPeople = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        string lastNameOfPeople = Console.ReadLine();

        var fullName1 = new Names.People("Emma");
        Console.WriteLine(fullName1);


        }
    }
}
