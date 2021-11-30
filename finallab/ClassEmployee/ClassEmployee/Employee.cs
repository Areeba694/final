using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassEmployee
{
    public abstract class Employee
    {
        public int basePay;
        public int base_hours;
        public int hourlyPayRate;
        public int no_of_units;
        public int overtimehours;
        public int overtimePay;
        public int unitPay;
    }

    abstract void Calculate_Salary();
}
        
   