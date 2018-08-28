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

            // gets year from user
            while (year == 0)
            {
                Console.WriteLine("Please enter year: ");

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

            // gets month from user
            while (month == 0)
            {
                Console.WriteLine("Please enter month: ");

                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if ((month > 0) && (month < 13))
                    {
                        continue;
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

            // reads file and assigns to myStaff
            myStaff = fr.ReadFile();

            // iterate over objects in staff
            for (int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    Console.WriteLine("\nEnter hours worked for " + myStaff[i].NameOfStaff + ":"); // user enters hours worked
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine()); // read hours worked entered by user

                    // calculate pay
                    myStaff[i].CalculatePay();

                    // display staff info
                    Console.WriteLine(myStaff[i].ToString());
                }
                catch (Exception e)
                {
                    i--;
                    Console.WriteLine("There has been a problem calculating the hours worked. Error message: " + e + " Recalculating...");
                }
            }

            PaySlip ps = new PaySlip(month, year);

            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
