using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.DIP
{
    public class EmployeeDetailsModified
    {
        private readonly ISalaryCalculate _salarycaculate;

        public float HoursWorked { get; set; }
        public float HourlyRate { get; set; }

        public EmployeeDetailsModified(ISalaryCalculate salaryCalculate)
        {
            _salarycaculate = salaryCalculate;
        }

        public float GetSalary()
        {
            return _salarycaculate.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}
