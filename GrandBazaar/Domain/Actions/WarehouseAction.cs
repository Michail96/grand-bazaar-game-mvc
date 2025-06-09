using GrandBazaar.Domain.Common;
using GrandBazaar.Domain.Enums;

wnamespace GrandBazaar.Domain.Actions
{
    public class WarehouseAction : IPlaceAction
    {
        private readonly IGameActionValidator _validator;
        
        public WarehouseAction(IGameActionValidator validator)
        {
            _validator = validator;
        }
        
        public bool Execute(Merchant merchant, string goodType)
        {
            Good good = _validator.ParseGood(goodType);
            merchant.Wheelbarrow.Goods[good] = merchant.Wheelbarrow.MaxCapacity;
        }
    }
}
