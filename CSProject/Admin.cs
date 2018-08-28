using System;
namespace CSProject
{
    public class Admin : Staff
    {
        // private constant fields that declares OT and hourly rates for admin employees
        private const float overtimeRate = 15.5F;
        private const float adminHourlyRate = 30;

        // auto-implemented property
        public float Overtime { get; private set; }

        public Admin(string name) : base(name, adminHourlyRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            // Calculates overtime pay
            if (HoursWorked > 160) {
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay = Overtime + TotalPay;
            }
        }

        // returns values as strings
        public override string ToString()
        {
            return "\nName of Staff: " + NameOfStaff
                 + "\nHourly Rate: " + adminHourlyRate
                 + "\nOvertime Rate: " + overtimeRate
                 + "\nHours Worked: " + HoursWorked
                 + "\nBasic Pay: " + BasicPay
                 + "\nTotal Pay: " + TotalPay;
        }
    }
}
