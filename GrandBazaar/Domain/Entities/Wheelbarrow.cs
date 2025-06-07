namespace GrandBazaar.Domain.Entities
{
    public class Wheelbarrow
    {
        public int MaxCapacity { get; set; } = 3;
        public Dictionary<Enums.Good, int> Goods { get; set; } = new Dictionary<Enums.Good, int>
        {
            { Enums.Good.Jewelry, 0 },
            { Enums.Good.Fabric, 0 },
            { Enums.Good.Spice, 0 },
            { Enums.Good.Fruit, 0 }
        };
        public int Rubies { get; set; } = 0;

        public bool AddGood(Enums.Good goodType, int quantity)
        {
            if (Goods[goodType] + quantity <= MaxCapacity)
            {
                Goods[goodType] += quantity;
                return true;
            }
            return false;
        }
    }
}
