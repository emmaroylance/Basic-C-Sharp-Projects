using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int text = Convert.ToInt32(Console.ReadLine());
            string text2 = Convert.ToString(text);
            File.WriteAllText(@"C:\Users\kent\Desktop\Bootcamp1\GitHub\log1.txt", text2);
            if (File.Exists(@"C:\Users\kent\Desktop\Bootcamp1\GitHub\log1.txt"))
            {
                using (StreamReader file = new StreamReader(@"C:\Users\kent\Desktop\Bootcamp1\GitHub\log1.txt"))
                {
                    int counter = 0;
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;
                    }

                    file.Close();
                }

                Console.ReadLine();
            }
        


        }
    }
}
