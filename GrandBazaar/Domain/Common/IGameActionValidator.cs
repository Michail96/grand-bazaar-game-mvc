namespace GrandBazaar.Domain.Common
{
    public class IGameActionValidator
    {
        void EnsureMerchantNotNull(Merchant merchant);
        Good ParseGood(string input);
    }
}
