namespace Chinook.Contracts.Report.Marketing
{
    public interface IItemSecondaryStatistic
    {
        IItemSecondary<int> A { get; }
        IItemSecondary<int> B { get; }
    }
}
