namespace SolidPrinciples.OpenClosedPrinciple.Example1.Violation
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(IEnumerable<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateSalaryTotal()
        {
            double salaryTotal = 0D;

            foreach (var devReport in _developerReports)
            {
                if (devReport.Level == "Senior developer")
                    salaryTotal += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                salaryTotal += devReport.HourlyRate * devReport.WorkingHours;
            }

            return salaryTotal;
        }
    }
}
