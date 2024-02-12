using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.DIP
{
    public class CalculateSalaryModified : ISalaryCalculate
    {
        public float CalculateSalary(float houtsworked, float hourlyrate)
        {
            return hourlyrate * houtsworked;
        }
    }
}
