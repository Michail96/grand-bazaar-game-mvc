using GrandBazaar.Domain.Entities;

namespace GrandBazaar.Domain.BonusCards
{
    public interface IBonusCard
    {
        string Name { get; }
        string Description { get; }
        bool Use(Merchant merchant, string? playersChoice = null);
    }
}
