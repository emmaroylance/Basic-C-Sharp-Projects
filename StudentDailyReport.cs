using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \r\nStudent Daily Report");
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool helpPlease = System.Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
}
