using System;

namespace CSProject
{
    public class Manager : Staff
    {
        // private constant field that declares hourly rate for manager
        private const float managerHourlyRate = 50;

        // auto-implemented property
        public int Allowance { get; private set; }

        public Manager(string name) : base(name, managerHourlyRate) {
            
        }

        // CalculatePay method
        public override void CalculatePay()
        {
            base.CalculatePay();

            // Allowance for manage
            Allowance = 1000;

            if (HoursWorked > 160) {
                TotalPay = TotalPay + Allowance;
            }
        }

        // returns values as strings
        public override string ToString()
        {
            return "\nName of Staff: " + NameOfStaff
                 + "\nHourly Rate: " + managerHourlyRate
                 + "\nHours Worked: " + HoursWorked
                 + "\nBasic Pay: " + BasicPay
                 + "\nTotal Pay: " + TotalPay;
        }
    }