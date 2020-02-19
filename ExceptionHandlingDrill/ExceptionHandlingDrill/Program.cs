using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> intList1 = new List<int>();
        intList1.Add(20202);
        intList1.Add(432);
        intList1.Add(580);
        intList1.Add(43);
        intList1.Add(99);
        intList1.Add(2);

        try
        {
            Console.WriteLine("Please pick a number! ");
            int userInteger = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < intList1.Count; i++)
            {
                int division = intList1[i] / userInteger;
                Console.WriteLine(division);
            }
            Console.ReadLine();
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
        }
        Console.ReadLine();
        Console.WriteLine("This was successful!");
        Console.ReadLine();
    }
}
