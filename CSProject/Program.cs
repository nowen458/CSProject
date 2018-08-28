using System;
using System.Collections.Generic;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> myStaff = new List<Staff>();
            FileReader fr = new FileReader();
            int month = 0;
            int year = 0;

            while (year == 0)
            {
                Console.WriteLine("\nPlease enter year: ");

                try
                {
                    // Code to convert the input to an interger
                    year = Convert.ToInt32(Console.ReadLine());
                } // end try
                catch (FormatException e)
                {
                    // Code to handle the exception
                    Console.WriteLine("Unfortunately, there was an error converting the year to an interger: " + e.Message);
                } // end catch
            } // end year while

            while (month == 0)
            {
                Console.WriteLine("\nPlease enter month: ");

                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if ((month > 0) && (month < 13))
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Month needs to be between 1 and 12. Please try again.");
                        month = 0;
                    }
                } // end try
                catch (FormatException e)
                {
                    Console.WriteLine("Unfortunately, there was an error converting the month to an interger: " + e.Message);
                } // end catch
            } // end month while
        }
    }
}
