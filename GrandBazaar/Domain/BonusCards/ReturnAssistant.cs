using GrandBazaar.Domain.Entities;

namespace GrandBazaar.Domain.BonusCards
{
    public class ReturnAssistant : IBonusCard
    {
        public string Name => "Return Assistant Card";
        public string Description => "Return an assistant to the supply.";
        private readonly IGameActionValidator _validator;

        public ReturnAssistant(IGameActionValidator validator)
        {
            _validator = validator;
        }

        public bool Use(Merchant merchant, string locationNumber)
        {
            _validator.EnsureMerchantNotNull(merchant);

            if (merchant.AvailableAssistants < merchant.MaximumAssistants)
            {
                merchant.AvailableAssistants++;

                //i need to arase the assistant from the specific location based on the locationNumber
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
