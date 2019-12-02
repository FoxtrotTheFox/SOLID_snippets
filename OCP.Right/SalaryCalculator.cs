using System.Collections.Generic;

namespace OCP.Right
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _devSalaryCalculators;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> devSalaryCalculators)
        {
            _devSalaryCalculators = devSalaryCalculators;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var calculator in _devSalaryCalculators)
            {
                totalSalaries += calculator.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}