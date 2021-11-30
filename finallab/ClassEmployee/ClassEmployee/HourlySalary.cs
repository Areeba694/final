using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassEmployee
{
    public class HourlySalary
    {
        public void Calculate_Salary()
        {
            if (Hours_worked > base_hours) ;
            {
                basePay = Hours_worked * base_hours;
                overtimehours = Hours_worked - base_hours;
                overtimePay = overtimehours * hourlyPayRate * OVERTIME_RATE;
                unitPay = 3 * no_of_units;
                GrossPay = basePay + overtimePay + unitPay;
            }
        }
    }
}