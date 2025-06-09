using GrandBazaar.Domain.Entities;

namespace GrandBazaar.Domain.Actions
{
    public interface IPlaceAction
    {
        bool Execute(Merchant merchant, string? playersChoice = null);
    }
}
