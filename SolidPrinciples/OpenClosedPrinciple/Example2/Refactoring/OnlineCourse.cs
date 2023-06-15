namespace SolidPrinciples.OpenClosedPrinciple.Example2.Refactoring
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine("Online subscription process...");
        }
    }
}
