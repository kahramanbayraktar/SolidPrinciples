namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring2
{
    public class WorkReport : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _workReportEntries;

        public WorkReport()
        {
            _workReportEntries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => _workReportEntries.Add(entry);

        public void RemoveEntryAt(int index) => _workReportEntries.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _workReportEntries.Select(x =>
                $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}").ToArray());
    }
}
