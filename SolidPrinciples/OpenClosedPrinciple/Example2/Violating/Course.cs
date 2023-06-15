namespace SolidPrinciples.OpenClosedPrinciple.Example2.Violating
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public void Subscribe(Student student)
        {
            if (Type == "online")
            {
                //subscribe to online course 
            }
            else if (Type == "offline")
            {
                //subscribe to offline course 
            }
        }
    }
}
