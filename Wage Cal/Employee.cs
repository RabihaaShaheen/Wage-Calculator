using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTKrusheelHirpara
{
    abstract class Employee
    {
        public enum EmployeeType
        {
            HourlyEmployee,
            CommissionEmployee,
            SalariedEmployee
        }
        public int EmployeeID;
        public string EmployeeName;

        public abstract void Show_Calculation();
        public abstract double GrossEarnings
        {
            get;
        }
        public abstract double Tax
        {
            get;
        }
        public abstract double NetEarnings
        {
            get;
        }
    }
}
