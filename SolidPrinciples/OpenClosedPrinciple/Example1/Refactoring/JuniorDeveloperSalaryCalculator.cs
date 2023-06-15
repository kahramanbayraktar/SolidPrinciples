using SolidPrinciples.OpenClosedPrinciple.Example1;

namespace SolidPrinciples.OpenClosedPrinciple.Example1.Refactoring
{
    public class JuniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDeveloperSalaryCalculator(DeveloperReport report) : base(report)
        {
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
        }
    }
}
