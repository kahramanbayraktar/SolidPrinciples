namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring2
{
    public class ScheduleTask
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
        public DateTime ExecuteOn { get; set; }
    }
}
