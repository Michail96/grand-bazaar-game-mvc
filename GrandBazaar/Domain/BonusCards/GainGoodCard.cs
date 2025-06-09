using GrandBazaar.Domain.Entities;
using GrandBazaar.Domain.Enums;

namespace GrandBazaar.Domain.BonusCards
{
    public class GainGoodCard : IBonusCard
    {
        public string Name => "Gain Good Card";
        public string Description => "Gain a good of your choice.";
        private readonly IGameActionValidator _validator;

        public GainGoodCard(IGameActionValidator validator)
        {
            _validator = validator;
        }

        public bool Use(Merchant merchant, string goodType)
        {
            _validator.EnsureMerchantNotNull(merchant);
            Good good = _validator.ParseGood(goodType);

            return merchant.Wheelbarrow.AddGood(good, 1);
        }
    }
}
