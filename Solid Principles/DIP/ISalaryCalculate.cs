using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.DIP
{
    public interface ISalaryCalculate
    {
        float CalculateSalary(float hoursworked, float hourlyRate);
    }
}
