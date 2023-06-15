namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Violation
{
    public class WorkReport
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport() => _entries = new List<WorkReportEntry>();

        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x =>
                $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}").ToArray());

        public void SaveToFile(string directory, string fileName)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(Path.Combine(directory, fileName), ToString());
        }
    }
}
