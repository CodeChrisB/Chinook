using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    internal class ItemSecondaryStatistic : IItemSecondaryStatistic
    {
        public IItemSecondary<int> A { get; set; }

        public IItemSecondary<int> B { get; set; }
    }
}
