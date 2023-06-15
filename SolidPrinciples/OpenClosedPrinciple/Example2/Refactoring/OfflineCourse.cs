namespace SolidPrinciples.OpenClosedPrinciple.Example2.Refactoring
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine("Offline subscription process...");
        }
    }
}
