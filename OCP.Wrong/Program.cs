using System;
using System.Collections.Generic;

namespace OCP.Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            var devReports = new List<DeveloperReport>
            {
                new DeveloperReport {Id = 1, Name = "Jon Doe", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
                new DeveloperReport {Id = 2, Name = "Jane Doe", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
                new DeveloperReport {Id = 3, Name = "Bob Martin", Level = "Senior developer", HourlyRate  = 999.9, WorkingHours = 180 }
            };

            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine($"SUM: {calculator.CalculateTotalSalaries()}");
        }
    }
}