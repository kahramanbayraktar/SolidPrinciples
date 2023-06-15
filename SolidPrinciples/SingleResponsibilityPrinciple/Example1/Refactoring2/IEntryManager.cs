namespace SolidPrinciples.SingleResponsibilityPrinciple.Example1.Refactoring2
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}
