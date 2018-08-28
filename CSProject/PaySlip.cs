using System;
using System.Collections.Generic;
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
    }
}
