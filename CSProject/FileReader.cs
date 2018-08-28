using System;
using System.Collections.Generic;
using System.IO;

namespace CSProject
{
    public class FileReader
    {
        public List<Staff> ReadFile()
        {
            // create variables
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt";
            string[] separator = { ", " };

            // if file exists
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    // while end of file is not reached
                    while (sr.EndOfStream !=true)
                    {
                        // splits on commas
                        result = path.Split(separator, StringSplitOptions.None);

                        // if employee is manager
                        if (result[1] == "Manager")
                        {
                            Manager manager = new Manager(result[0]);
                            myStaff.Add(manager); // add to myStaff object
                        } // end if
                        // if employee is admin employee
                        else if (result[1] == "Admin")
                        {
                            Admin admin = new Admin(result[0]);
                            myStaff.Add(admin); // add to myStaff object
                        } // end else if
                    } // end while
                    sr.Close(); // close StreamReader
                } // end using
            } // end if
            // if file is not found, print error message
            else
            {
                Console.WriteLine("File does not exist.");
            }

            return myStaff;
        }

    }
}
