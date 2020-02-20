using System;
using System.Collections.Generic;
using System.Linq;


namespace IterationDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type in an adjective");

            //string[] animals = { "horse", "elephant", "lion", "wolf" };

            //string adjective = Console.ReadLine().ToLower();

            //for (int j = 0; j < animals.Length; j++)
            //{
            //    Console.WriteLine(adjective + " " + animals[j]);
            //}

            //Console.ReadLine();


            ////This is my infinite loop
            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            ////This is the fix to my infinite loop
            //for (int a = 0; a < 50; a++)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            //int[] numOfTickets = { 0, 2, 5, 3, 1, 1, 5 };
            //for (int p = 0; p < numOfTickets.Length; p++)
            //{
            //    if (numOfTickets[p] < 3)
            //    {
            //        Console.WriteLine("These ticket amounts are eligible for car insurance: " + numOfTickets[p]);
            //    }
            //}

            //Console.ReadLine();

            //int[] numOfArrests = { 0, 2, 1, 2, 0, 0, 5 };
            //for (int p = 0; p < numOfArrests.Length; p++)
            //{
            //    if (numOfArrests[p] <= 1)
            //    {
            //        Console.WriteLine("These arrest amounts are eligible to tour the White House: " + numOfArrests[p]);
            //    }
            //}

            //Console.ReadLine();

            //Console.WriteLine("Please search for an email in the list:");
            //List<string> emails = new List<string>() { "johnsmith@gmail.com", "janedoe@gmail.com", "eatsnails@gmail.com", "gorunning@gmail.com" };
            //string emailInput = Console.ReadLine();
            //int q = 0;
            //do
            //{
            //    if (emailInput == emails[q])
            //    {

            //        Console.WriteLine(q);
            //        q++;
            //        Console.ReadLine();
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Oh dear! That text isn't part of my list!");
            //        q++;
            //    }
            //} while (q < emails.Count);
            //Console.ReadLine();


            //Console.WriteLine("Please search for a state in the list:");
            //List<string> states = new List<string>() { "Utah", "Arizona", "Arkansas", "Arizona", "Utah", "Arkansas", "Washington" };
            //string stateInput = Console.ReadLine();
            //int t;
            //for (t = 0; t < states.Count; t++)
            //{
            //    if (stateInput == states[t])
            //    {
            //        Console.WriteLine(t);
            //    }

            //    else
            //    {
            //        Console.WriteLine("Oh dear! That text isn't part of my list!");

            //    }
            //}
            //Console.ReadLine();


            List<string> foods = new List<string>() { "mac 'n cheese", "hot dog", "grilled chicken", "mac 'n cheese" };
            List<string> duplicateFoods = new List<string>();
            foreach (string food in foods)
            {
                if (!duplicateFoods.Contains(food))
                {
                    duplicateFoods.Add(food);
                    Console.WriteLine(food + " hasn't appeared.");
                }
                else if (duplicateFoods.Contains(food))
                {
                    Console.WriteLine(food + " has appeared.");
                }
            }
            
        }
    }
}
