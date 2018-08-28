using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSProject
{
    class PaySlip
    {
        // declaring fields
        private int month;
        private int year;

        // declaring enum
        enum MonthsOfYear
        {
            JAN = 1,
            FEB = 2,
            MAR = 3,
            APR = 4,
            MAY = 5,
            JUN = 6,
            JUL = 7,
            AUG = 8,
            SEP = 9,
            OCT = 10,
            NOV = 11,
            DEC = 12,
        }

        // PaySlip Constructor
        public PaySlip (int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;

            foreach (Staff f in myStaff)
            {
                path = f.NameOfStaff + ".txt";

                StreamWriter sw = new StreamWriter(path);

                // payslip description
                sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)month, year);
                sw.WriteLine("====================");

                // name and hours worked
                sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                sw.WriteLine("Hours Worked: {0}", f.HoursWorked);

                // blank line
                sw.WriteLine("");

                // basic pay and allowance
                sw.WriteLine("Basic Pay: {0:C}", f.BasicPay);
                // if type of Staff object is Manager
                if (f.GetType() == typeof(Manager))
                {
                    sw.WriteLine("Allowance Pay: {0:C}", ((Manager)f).Allowance);
                }
                // if type of Staff object is Admin
                else if (f.GetType() == typeof(Admin))
                {
                    sw.WriteLine("Overtime Pay: {0:C}", ((Admin)f).Overtime);
                }

                // blank line
                sw.WriteLine("");
                sw.WriteLine("====================");

                // total pay
                sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                sw.WriteLine("====================");


                sw.Close(); // close StreamWriter

            } // end foreach
        } // end GeneratePaySlip

        public void GenerateSummary(List<Staff> myStaff)
        {
            // LINQ query to determine employees with less than 10 hours
            var result =
                from f in myStaff
                where f.HoursWorked < 10
                orderby f.NameOfStaff
                select new { f.NameOfStaff, f.HoursWorked };

            string path = "summary.txt";

            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine("Staff with less than 10 working hours:");
            // blank line
            sw.WriteLine("");

            // print name of staff and hours worked
            foreach (var r in result)
            {
                sw.WriteLine("Name of Staff: {0}, Hours Worked: {1}", r.NameOfStaff, r.HoursWorked);
            }

            sw.Close(); // close StreamWriter

        } // end GenerateSummary

        // returns values as strings
        public override string ToString()
        {
            return base.ToString();
        }
    } 
}
