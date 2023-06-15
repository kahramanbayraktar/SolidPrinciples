using SolidPrinciples.OpenClosedPrinciple.Example1;

namespace SolidPrinciples.OpenClosedPrinciple.Example1.Refactoring
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport report)
        {
            DeveloperReport = report;
        }

        public abstract double CalculateSalary();
    }
}
