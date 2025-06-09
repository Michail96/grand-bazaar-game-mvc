using GrandBazaar.Domain.Entities;

namespace GrandBazaar.Domain.BonusCards
{
    public class TakeLiraCard : IBonusCard
    {
        public string Name => "Take 5 Lira Card";
        public string Description => "Take 5 Lira from the bank.";
        private readonly IGameActionValidator _validator;

        public TakeLiraCard(IGameActionValidator validator)
        {
            _validator = validator;
        }

        public bool Use(Merchant merchant, string? playersChoice = null)
        {
            _validator.EnsureMerchantNotNull(merchant);
            return merchant.AddLira(5);
        }
    }
}
