
namespace OCP.Right
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport)
            : base(developerReport)
        {
        }

        public override double CalculateSalary() 
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
        }
    }

}
