using GrandBazaar.Domain.Entities;

namespace GrandBazaar.Domain.BonusCards
{
    public class TakeLiraCard : IBonusCard
    {
        public string Name => "Take 5 Lira Card";
        public string Description => "Take 5 Lira from the bank.";
        public bool Use(Merchant merchant, string? playersChoice = null)
        {
            BonusCardValidator.EnsureMerchantNotNull(merchant);
            return merchant.AddLira(5);
        }
    }
}
