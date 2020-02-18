using System;
using System.Collections.Generic;


namespace ArraysAndListsDrill
{
    class Program
    {
        static void Main()
        {
            int[] numArray = new int[] { 4, 500, 102, 20, 530, 61, 18 };

            Console.WriteLine(
                "Welcome to my Arrays & Lists!\nPlease type a number between 0 and 6 to select an object from my number array!");
            int integerSelected = Convert.ToInt32(Console.ReadLine());

            if (integerSelected == 0)
            {
                Console.WriteLine(numArray[0]);
                Console.ReadLine();
            }
            else if (integerSelected == 1)
            {
                Console.WriteLine(numArray[1]);
                Console.ReadLine();
            }
            else if (integerSelected == 2)
            {
                Console.WriteLine(numArray[2]);
                Console.ReadLine();
            }
            else if (integerSelected == 3)
            {
                Console.WriteLine(numArray[3]);
                Console.ReadLine();
            }
            else if (integerSelected == 4)
            {
                Console.WriteLine(numArray[4]);
                Console.ReadLine();
            }
            else if (integerSelected == 5)
            {
                Console.WriteLine(numArray[5]);
                Console.ReadLine();
            }

            else if (integerSelected == 6)
            {
                Console.WriteLine(numArray[6]);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Oh dear! You have selected an index that doesn't exist!");
                Console.ReadLine();
            }




            string[] StringArray = new string[] { "horse", "dog", "cat", "hamster", "bird" };
            Console.WriteLine("Please type a number between 0 and 4 to select an object from my animal array!");
            int integerSelected3 = Convert.ToInt32(Console.ReadLine());
            if (integerSelected3 == 0)
            {
                Console.WriteLine(StringArray[0]);
                Console.ReadLine();
            }
            else if (integerSelected3 == 1)
            {
                Console.WriteLine(StringArray[1]);
                Console.ReadLine();
            }
            else if (integerSelected3 == 2)
            {
                Console.WriteLine(StringArray[2]);
                Console.ReadLine();
            }
            else if (integerSelected3 == 3)
            {
                Console.WriteLine(StringArray[3]);
                Console.ReadLine();
            }
            else if (integerSelected3 == 4)
            {
                Console.WriteLine(StringArray[4]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Oh dear! You have selected an index that does not exist!");
                Console.ReadLine();

            }


            List<int> intList2 = new List<int>();
            intList2.Add(20202);
            intList2.Add(432);
            intList2.Add(580);
            intList2.Add(43);
            intList2.Add(99);
            intList2.Add(2);

            Console.WriteLine("Please type a number between 0 and 5 to select an object from my number list! ");
            Console.ReadLine();

            int integerSelected4 = Convert.ToInt32(Console.ReadLine());

            if (integerSelected4 == 0)
            {
                Console.WriteLine(intList2[0]);
                Console.ReadLine();
            }

            else if (integerSelected4 == 1)
            {
                Console.WriteLine(intList2[1]);
                Console.ReadLine();
            }
            else if (integerSelected4 == 2)
            {
                Console.WriteLine(intList2[2]);
                Console.ReadLine();
            }
            else if (integerSelected4 == 3)
            {
                Console.WriteLine(intList2[3]);
                Console.ReadLine();
            }
            else if (integerSelected4 == 4)
            {
                Console.WriteLine(intList2[4]);
                Console.ReadLine();
            }
            else if (integerSelected4 == 5)
            {
                Console.WriteLine(intList2[5]);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Oh dear! You have selected an index that does not exist!");
                Console.ReadLine();

            }






        }
    }
}

