using SolidPrinciples.OpenClosedPrinciple.Example1;
using SolidPrinciples.OpenClosedPrinciple.Example1.Refactoring;
using SolidPrinciples.SingleResponsibilityPrinciple.Example1;
using SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring2;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SRP
            //SRPViolating();
            //SRPRefactored();
            //SRPRefactored2();

            // OCP
            OCPViolating();
            OCPRefactored();
        }

        #region SRP

        static void SRPViolating()
        {
            var report = new SingleResponsibilityPrinciple.Example1.Violation.WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });

            Console.WriteLine(report.ToString());
        }

        static void SRPRefactored()
        {
            var report = new SingleResponsibilityPrinciple.Example1.Refactoring.WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });

            Console.WriteLine(report.ToString());

            var saver = new SingleResponsibilityPrinciple.Example1.Refactoring.FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
        }

        static void SRPRefactored2()
        {
            var scheduler = new Scheduler();
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });

            Console.WriteLine(scheduler.ToString());

            // Now I'm sending an object of IEntryManager<T> to FileSaver's SaveToFile method,
            // and this makes FileSaver less coupling and more extendible.
            // Notice that SaveToFile now has a generic parameter.

            var saver = new FileSaver();
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
        }

        #endregion

        #region OCP

        static void OCPViolating()
        {
            var devReports = new List<DeveloperReport>
            {
                new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
                new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
                new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
            };

            var calculator = new OpenClosedPrinciple.Example1.Violation.SalaryCalculator(devReports);
            Console.WriteLine($"Salary total is {calculator.CalculateSalaryTotal()}.");
        }

        static void OCPRefactored()
        {
            var salaryCalculators = new List<BaseSalaryCalculator>
            {
                new SeniorDeveloperSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 }),
                new JuniorDeveloperSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 }),
                new SeniorDeveloperSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 })
            };

            var calculator = new OpenClosedPrinciple.Example1.Refactoring.SalaryCalculator(salaryCalculators);
            Console.WriteLine($"Salary total is {calculator.CalculateSalaryTotal()}.");
        }

        #endregion
    }
}