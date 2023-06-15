namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring2
{
    public class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _scheduleTasks;

        public Scheduler()
        {
            _scheduleTasks = new List<ScheduleTask>();
        }

        public void AddEntry(ScheduleTask entry) => _scheduleTasks.Add(entry);

        public void RemoveEntryAt(int index) => _scheduleTasks.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _scheduleTasks.Select(x =>
                $"Id: {x.TaskId}, Content: {x.Content}, ExecutionDate: {x.ExecuteOn}").ToArray());
    }
}
