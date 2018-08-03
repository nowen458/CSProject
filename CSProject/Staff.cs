using System;
namespace CSProject
{
    public class Staff
    {
        // declaring fields
        private float hourlyRate;
        private int hWorked; // backing field for Hoursworked

        // auto-implemented properties
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int HoursWorked {
            get {
                return hWorked;
            }

            set {
                if (value > 0) {
                    hWorked = value;
                } else {
                    hWorked = 0;
                }
            }
        }

        // Staff constructor
        public Staff(string name, float rate) {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        // CalculatePay method
        public virtual void CalculatePay() {
            // Prints out text
            Console.WriteLine("Calculating Pay...");

            // Calculates basic pay
            BasicPay = hWorked * hourlyRate;

            // Adds pay calculated to this point to TotalPay
            TotalPay = BasicPay;
        }

        // returns values as strings
        public override string ToString() {
           return "\nName of Staff: " + NameOfStaff
                + "\nHourly Rate: " + hourlyRate
                + "\nHours Worked: " + HoursWorked
                + "\nBasic Pay: " + BasicPay
                + "\nTotal Pay: " + TotalPay;
        }

    }
}
