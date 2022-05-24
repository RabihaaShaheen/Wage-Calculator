using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTKrusheelHirpara
{
    class SalariedEmployee : Employee
    {
        MainWindow mw = new MainWindow();
        public override double GrossEarnings
        {
            get
            {
                double GE = 0;
                int WeeklySalary = int.Parse(mw.textBox1.Text);
                GE = WeeklySalary;
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

        public override void Show_Calculation()
        {
            mw.textBox3.Text = GrossEarnings.ToString();
            mw.textBox4.Text = Tax.ToString();
            mw.textBox5.Text = NetEarnings.ToString();
        }
    }
}
