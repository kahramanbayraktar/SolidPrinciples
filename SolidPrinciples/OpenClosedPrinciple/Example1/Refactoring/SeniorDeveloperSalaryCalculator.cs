using SolidPrinciples.OpenClosedPrinciple.Example1;

namespace SolidPrinciples.OpenClosedPrinciple.Example1.Refactoring
{
    public class SeniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDeveloperSalaryCalculator(DeveloperReport report) : base(report)
        {
        }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
        }
    }
}
