using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopToyShop.Model
{
    public class Salary
    {
        public int EmployeeId { get; set; }
        public int SalaryId { get; set; }
        public DateTime SalaryBegin { get; set; }
        public DateTime SalaryEnd { get; set; }
        public Double BasicSalary { get; set; }
        public Double Allowances { get; set; }
        public Double MonthlySalary { get; set; }


        

    }
}
