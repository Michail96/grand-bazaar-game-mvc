namespace GrandBazaar.Domain.Actions
{
    public class WainwrightAction : IPlaceAction
    {
        public bool Execute(Merchant merchant, string? playersChoice = null)
        {
            merchant.wheelbarrow.MaxCapacity += 1;
            if (merchant.wheelbarrow.MaxCapacity = 5)
            {
                merchant.wheelbarrow.rubies += 1;
            }

            return true;
        }
    }
}
