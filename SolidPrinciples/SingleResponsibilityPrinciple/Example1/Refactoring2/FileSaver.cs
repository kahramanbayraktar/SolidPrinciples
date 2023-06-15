namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring2
{
    public class FileSaver
    {
        public void SaveToFile<T>(string directory, string fileName, IEntryManager<T> report)
        {
            var rootDir = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;
            var fullDir = Path.Combine(rootDir, directory);

            if (!Directory.Exists(fullDir))
                Directory.CreateDirectory(fullDir);

            File.WriteAllText(Path.Combine(fullDir, fileName), report.ToString());
        }
    }
}
