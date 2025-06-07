using GrandBazaar.Domain.Entities;
using GrandBazaar.Domain.Enums;

namespace GrandBazaar.Domain.BonusCards
{
    public class GainGoodCard : IBonusCard
    {
        public string Name => "Gain Good Card";
        public string Description => "Gain a good of your choice.";
        public bool Use(Merchant merchant, string goodType)
        {
            BonusCardValidator.EnsureMerchantNotNull(merchant);
            Good good = BonusCardValidator.ParseGood(goodType);

            return merchant.Wheelbarrow.AddGood(good, 1);
        }
    }
}
