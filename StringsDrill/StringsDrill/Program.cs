using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string verb = "walking";
            string noun = "She";
            string exclamationPoint = "!";
            Console.WriteLine("Margaret is awesome! " + noun + " was " + verb + " to Smith's and she decided to get me a candy bar" + exclamationPoint);
            Console.ReadLine();

            string name = "emma";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Emma. ");
            sb.Append("My favorite food is popcorn ");
            sb.Append("and I love to go hiking in the summertime.");
            sb.Append(" I also love to spend time with my puppies, Harry & Charlie.");
            sb.Append(" They are honestly the cutest dogs ever!");
            Console.WriteLine(sb);
            Console.ReadLine();




        }
    }
}
