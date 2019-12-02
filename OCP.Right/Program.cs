using System;
using System.Collections.Generic;

namespace OCP.Right
{
    class Program
    {
        static void Main(string[] args)
        {
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Jon Doe", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Jabe Does", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Bob Martin", Level = "Senior developer", HourlyRate = 999.9, WorkingHours = 180 })
            };

            SalaryCalculator salaryCalculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"SUM: {salaryCalculator.CalculateTotalSalaries()}");
        }
    }
}