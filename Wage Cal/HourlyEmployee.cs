using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace MTKrusheelHirpara
{
    class HourlyEmployee : Employee
    {
        MainWindow mw = new MainWindow();
        public override void Show_Calculation()
        {
            mw.t *= 2;
        }
        public override double GrossEarnings
        {
            get
            {
                double GE = 0;
                int HoursWorked;
                int.TryParse(this.mw.textBox1.Text.ToString(),out HoursWorked);
                int HourlyWage;
                int.TryParse(this.mw.textBox2.Text.ToString(),out HourlyWage);
                if (HoursWorked <= 40)
                {
                    GE = HoursWorked * HourlyWage;
                }
                else if(HoursWorked>40)
                {
                    GE = 40 * HourlyWage + (HoursWorked - 40) * HourlyWage * 1.5;
                }
                return GE;
            }
        }

        public override double NetEarnings
        {
            get
            {
                double NE = 0;
                NE = GrossEarnings - Tax;
                return NE;
            }
        }

        public override double Tax
        {
            get
            {
                double T = 0;
                T = (GrossEarnings * 20) / 100;
                return T;
            }
        }
    }
}
