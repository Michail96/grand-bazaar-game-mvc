using GrandBazaar.Domain.Entities;
using GrandBazaar.Domain.Enums;

namespace GrandBazaar.Domain.BonusCards
{
    public static class BonusCardValidator
    {
        public static void EnsureMerchantNotNull(Merchant merchant)
        {
            if (merchant == null)
                throw new ArgumentNullException(nameof(merchant), "Merchant cannot be null.");
        }

        public static Good ParseGood(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Good cannot be null or empty.", nameof(input));

            if (!Enum.TryParse<Good>(input, true, out var result))
                throw new ArgumentException($"Invalid good type: {input}", nameof(input));

            return result;
        }
    }
}
