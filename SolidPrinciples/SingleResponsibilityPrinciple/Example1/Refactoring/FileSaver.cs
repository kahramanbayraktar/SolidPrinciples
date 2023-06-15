namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring
{
    public class FileSaver
    {
        public void SaveToFile(string directory, string fileName, WorkReport report)
        {
            var rootDir = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;
            var fullDir = Path.Combine(rootDir, directory);

            if (!Directory.Exists(fullDir))
                Directory.CreateDirectory(fullDir);

            File.WriteAllText(Path.Combine(fullDir, fileName), report.ToString());
        }
    }
}
