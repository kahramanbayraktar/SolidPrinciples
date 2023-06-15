namespace SolidPrinciples.OpenClosedPrinciple.Example1.Refactoring
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _salaryCalculators;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> salaryCalculators)
        {
            _salaryCalculators = salaryCalculators;
        }

        public double CalculateSalaryTotal()
        {
            double salaryTotal = 0D;

            foreach (var salaryCalculator in _salaryCalculators)
            {
                salaryTotal += salaryCalculator.CalculateSalary();
            }

            return salaryTotal;
        }
    }
}
