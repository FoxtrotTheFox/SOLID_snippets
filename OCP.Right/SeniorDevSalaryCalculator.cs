using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Right
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport report)
            : base(report)
        {
        }

        public override double CalculateSalary() 
        { 
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
        }
    }
}
