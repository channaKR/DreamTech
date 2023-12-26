using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopToyShop.Service
{
    public class SalaryService
    {
        double NoPayValue,BasePayValue,GrossPayValue;
        public double NoPay(double totalsalary,int daterange, int absentdate) 
        {
            NoPayValue = (totalsalary / (double)daterange)*absentdate;

            return NoPayValue;
        }

        public double BasePay
            (
                double NoPay, double MonthlySalary, double Allownces,int OverTimeRate,float OverTime,float OverTimeHours
                

            )
        {
            BasePayValue = MonthlySalary + Allownces + (OverTimeRate * OverTimeHours);

            return BasePayValue;
        }

        public double GrossPay(double BasePay, double NoPay, float TaxRate)
        {

            GrossPayValue = BasePay - (NoPay+(BasePay* TaxRate/100));
            return GrossPayValue;
        }

    }
}
