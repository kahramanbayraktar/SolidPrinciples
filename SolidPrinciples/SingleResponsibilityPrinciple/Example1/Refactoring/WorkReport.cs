﻿namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring
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
    }
}
